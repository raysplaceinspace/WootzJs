#region License
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
#endregion

using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.CSharp;
using WootzJs.Compiler.JsAst;

namespace WootzJs.Compiler
{
    public class YieldGenerator : SyntaxRewriter
    {
        private Compilation compilation;
        private SyntaxTree syntaxTree;
        private SemanticModel semanticModel;

        public YieldGenerator(Compilation compilation, SyntaxTree syntaxTree, SemanticModel semanticModel)
        {
            this.compilation = compilation;
            this.syntaxTree = syntaxTree;
            this.semanticModel = semanticModel;
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var yieldClasses = new List<ClassDeclarationSyntax>();
            int currentGeneratorNameIndex = 1;
            foreach (var method in node.Members.OfType<MethodDeclarationSyntax>().Where(x => YieldChecker.HasYield(x)))
            {
                var yieldGenerator = new YieldClassGenerator(compilation, method);
                var enumerator = yieldGenerator.CreateEnumerator();
                yieldClasses.Add(enumerator);
            }

            if (yieldClasses.Any())
            {
                return node.AddMembers(yieldClasses.ToArray());
            }
            else
            {
                return base.VisitClassDeclaration(node);
            }
        }

        public JsNode ReturnNewGenerator()
        {
            return null;
//            return Js.Return(transformer.idioms.)
        }
    }
}
