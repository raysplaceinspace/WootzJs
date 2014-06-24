﻿using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WootzJs.Compiler
{
    public class AsyncState
    {
        public int Index { get; set; }
        public List<StatementSyntax> Statements { get; set; }
        public AsyncState Next { get; set; }
            
        public AsyncState()
        {
            Statements = new List<StatementSyntax>();
        }

        public void Add(StatementSyntax statement)
        {
            Statements.Add(statement);
        }

        public override string ToString()
        {
            return Index + ": " + string.Join(" ", Statements);
        }
    }
}