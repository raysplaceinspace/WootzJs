//-----------------------------------------------------------------------
// <copyright>
// The MIT License (MIT)
// 
// Copyright (c) 2014 Kirk S Woll
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

namespace System.Linq.Expressions
{
    /// <summary>
    /// Describes the node types for the nodes of an expression tree.
    /// </summary>
    public enum ExpressionType
    {
        Add,
        AddChecked,
        And,
        AndAlso,
        ArrayLength,
        ArrayIndex,
        Call,
        Coalesce,
        Conditional,
        Constant,
        Convert,
        ConvertChecked,
        Divide,
        Equal,
        ExclusiveOr,
        GreaterThan,
        GreaterThanOrEqual,
        Invoke,
        Lambda,
        LeftShift,
        LessThan,
        LessThanOrEqual,
        ListInit,
        MemberAccess,
        MemberInit,
        Modulo,
        Multiply,
        MultiplyChecked,
        Negate,
        UnaryPlus,
        NegateChecked,
        New,
        NewArrayInit,
        NewArrayBounds,
        Not,
        NotEqual,
        Or,
        OrElse,
        Parameter,
        Power,
        Quote,
        RightShift,
        Subtract,
        SubtractChecked,
        TypeAs,
        TypeIs,
        Assign,
        Block,
        DebugInfo,
        Decrement,
        Dynamic,
        Default,
        Extension,
        Goto,
        Increment,
        Index,
        Label,
        RuntimeVariables,
        Loop,
        Switch,
        Throw,
        Try,
        Unbox,
        AddAssign,
        AndAssign,
        DivideAssign,
        ExclusiveOrAssign,
        LeftShiftAssign,
        ModuloAssign,
        MultiplyAssign,
        OrAssign,
        PowerAssign,
        RightShiftAssign,
        SubtractAssign,
        AddAssignChecked,
        MultiplyAssignChecked,
        SubtractAssignChecked,
        PreIncrementAssign,
        PreDecrementAssign,
        PostIncrementAssign,
        PostDecrementAssign,
        TypeEqual,
        OnesComplement,
        IsTrue,
        IsFalse,
    }
}
