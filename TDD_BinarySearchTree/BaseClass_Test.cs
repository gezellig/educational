using System;
using Xunit;
using DotNet;

namespace TDD_BinarySearchTree
{
    public class NodeTest
    {
        [Fact]
        public void Test1()
        {
	    var bst = new Bst();
	    
	    bst.AddNode(3);
	    bst.AddNode(5);
	    bst.AddNode(8);
	    
	    Assert.Equal(3, bst.Count());
        }
    }
}
