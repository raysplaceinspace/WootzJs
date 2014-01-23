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

using System.Runtime.WootzJs;

namespace WootzJs.Compiler.Tests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void ConstructorsWithOverloads()
        {
            var test1 = new TestClass();
            var test2 = new TestClass("foo");
            var test3 = new TestClass(5);

            QUnit.AreEqual(test1.Arg1, "none");
            QUnit.AreEqual(test2.Arg1, "string");
            QUnit.AreEqual(test3.Arg1, "int");
        }
         
        [Test]
        public void InitializedStaticField()
        {
            QUnit.AreEqual(ClassWithStaticInitializedField.InitializedValue, "foo");
        }
         
        [Test]
        public void StaticConstructor()
        {
            QUnit.AreEqual(ClassWithStaticConstructor.InitializedValue, "foo");
        }
         
        public class TestClass
        {
            private string arg1;

            public TestClass()
            {
                arg1 = "none";
            }

            public TestClass(string arg1)
            {
                this.arg1 = "string";
            }

            public TestClass(int arg1)
            {
                this.arg1 = "int";
            }

            public string Arg1
            {
                get { return arg1; }
            }
        }

        public class ClassWithStaticInitializedField
        {
            public static string InitializedValue = "foo";
        }

        public class ClassWithStaticConstructor
        {
            public static string InitializedValue;

            static ClassWithStaticConstructor()
            {
                InitializedValue = "foo";
            }
        }
    }
}
