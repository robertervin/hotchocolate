using System;

namespace StrawberryShake.VisualStudio.Language
{
    // Implements the parsing rules in the Values section.
    public ref partial struct StringGraphQLClassifier
    {
        /// <summary>
        /// Parses a value.
        /// <see cref="IValueNode" />:
        /// - Variable [only if isConstant is <c>false</c>]
        /// - IntValue
        /// - FloatValue
        /// - StringValue
        /// - BooleanValue
        /// - NullValue
        /// - EnumValue
        /// - ListValue[isConstant]
        /// - ObjectValue[isConstant]
        /// <see cref="BooleanValueNode" />: true or false.
        /// <see cref="NullValueNode" />: null
        /// <see cref="EnumValueNode" />: Name but not true, false or null.
        /// </summary>
        /// <param name="isConstant">
        /// Defines if only constant values are allowed;
        /// otherwise, variables are allowed.
        /// </param>
        private void ParseValueLiteral(bool isConstant)
        {
            if (_reader.Kind == TokenKind.LeftBracket)
            {
                ParseList(isConstant);
            }
            else if (_reader.Kind == TokenKind.LeftBrace)
            {
                ParseObject(isConstant);
            }
            else if (_isString[(int)_reader.Kind])
            {
                ParseStringLiteral();
            }
            else if (_isScalar[(int)_reader.Kind])
            {
                ParseNumberScalarValue();
            }
            else if (_reader.Kind == TokenKind.Name)
            {
                ParseEnumValue();
            }
            else if (_reader.Kind == TokenKind.Dollar && !isConstant)
            {
                ParseVariableName(true);
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
                MoveNext();
            }
        }

        private void ParseStringLiteral(
            SyntaxClassificationKind kind = SyntaxClassificationKind.StringLiteral)
        {
            if (_isString[(int)_reader.Kind])
            {
                classifications.AddClassification(
                    kind,
                    _reader.Token);
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
            }
            MoveNext();
        }

        /// <summary>
        /// Parses a list value.
        /// <see cref="ListValueNode" />:
        /// - [ ]
        /// - [ Value[isConstant]+ ]
        /// </summary>
        /// <param name="isConstant">
        /// Defines if only constant values are allowed;
        /// otherwise, variables are allowed.
        /// </param>
        private void ParseList(bool isConstant)
        {
            if (_reader.Kind == TokenKind.LeftBracket)
            {
                // skip opening token
                classifications.AddClassification(
                    SyntaxClassificationKind.Bracket,
                    _reader.Token);
                MoveNext();

                while (_reader.Kind != TokenKind.RightBracket)
                {
                    ParseValueLiteral(isConstant);
                }

                // skip closing token
                classifications.AddClassification(
                    SyntaxClassificationKind.Bracket,
                    _reader.Token);
                Expect(SyntaxClassificationKind.Bracket, TokenKind.RightBracket);
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
            }
        }

        /// <summary>
        /// Parses an object value.
        /// <see cref="ObjectValueNode" />:
        /// - { }
        /// - { Value[isConstant]+ }
        /// </summary>
        /// <param name="isConstant">
        /// Defines if only constant values are allowed;
        /// otherwise, variables are allowed.
        /// </param>
        private void ParseObject(bool isConstant)
        {
            if (_reader.Kind == TokenKind.LeftBrace)
            {
                // skip opening token
                classifications.AddClassification(
                    SyntaxClassificationKind.Brace,
                    _reader.Token);
                MoveNext();

                while (_reader.Kind != TokenKind.RightBrace)
                {
                    ParseObjectField(isConstant);
                }

                // skip closing token
                classifications.AddClassification(
                    SyntaxClassificationKind.Brace,
                    _reader.Token);
                Expect(SyntaxClassificationKind.Brace, TokenKind.RightBrace);
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
            }
        }

        private void ParseObjectField(bool isConstant)
        {
            ParseName(SyntaxClassificationKind.InputFieldIdentifier);
            ParseColon();
            ParseValueLiteral(isConstant);
        }


        private void ParseNumberScalarValue()
        {
            if (_reader.Kind == TokenKind.Float
                || _reader.Kind == TokenKind.Integer)
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.NumberLiteral,
                    _reader.Token);
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
            }
            MoveNext();
        }


        private void ParseEnumValue()
        {
            if (_reader.Value.SequenceEqual(GraphQLKeywords.True)
                || _reader.Value.SequenceEqual(GraphQLKeywords.False))
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.BooleanLiteral,
                    _reader.Token);
                MoveNext();
            }
            else if (_reader.Value.SequenceEqual(GraphQLKeywords.Null))
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.NullLiteral,
                    _reader.Token);
                MoveNext();
            }
            else
            {
                classifications.AddClassification(
                    SyntaxClassificationKind.Error,
                    _reader.Token);
                MoveNext();
            }
        }
    }
}
