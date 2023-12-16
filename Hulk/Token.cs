﻿namespace Hulk
{
    public enum TokenType
    {
        //?tipo de datos
        NUMBER,
        STRING,
        BOOLEAN,

        //? operadores
        OPERATOR,
        EQUAL,
        DO,

        // puntuadores
        L_PHARENTESYS,
        R_PHARENTESYS,
        PRINT,
        COMMA,
        D_COMMA,
        COMMILLAS,

        //?Own Words
        LET,
        IN,
        IF,
        ELSE,
        TRUE,
        FALSE,
        FUNCTION,

        //? Palabras Reservadas
        COS,
        SEN,
        LOG,

        //?
        VARIABLE,
        EOF
    }

    // Definiendo objeto token
    public class Token
    {
        public TokenType Type { get; } //tipo de token
        public object Value { get; } //valor del token

        public Token(TokenType type, object value)
        {
            Type = type;
            Value = value;
        }

        //public override string ToString() {
        //    return $"Token({Type}, {Value})";
        //}
    }

}
