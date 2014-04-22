﻿using System.Threading.Tasks;

namespace WootzJs.Compiler.Tests.Threading.Tasks
{
    [TestFixture]
    public class TaskContinuationTests
    {
        [Test]
        public void SimpleContinuation()
        {
            var task = Task.FromResult("foo");
            var continuation = task.ContinueWith(x => x.Result + "bar");
            QUnit.AreEqual("foobar", continuation.Result);
        }

        [Test]
        public void AsyncContinuation()
        {
            var source = new TaskCompletionSource<string>();
            var task = source.Task.ContinueWith(x => x.Result + "bar");
            source.SetResult("foo");
            QUnit.AreEqual("foobar", task.Result);
        }
    }
}