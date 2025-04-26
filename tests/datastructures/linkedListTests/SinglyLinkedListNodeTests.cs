using DataStructures.LinkedList.Singly;

namespace linkedListTests;

public class SinglyLinkedListNodeTests
{
    [Fact]
    public void DefaultValueIsNull()
    {
        // Arrange
        var node = new SinglyLinkedListNode<string>();

        // Act
        var item = node.Value;

        // Assert
        Assert.Null(item);
    }

    [Fact]
    public void NodeWithValueHasCorrectValue()
    {
        // Arrange
        var node = new SinglyLinkedListNode<int>();
        var node1 = new SinglyLinkedListNode<int>();

        // Act
        node.Value = 3;
        node1.Value = 10;

        node.Next = node1;

        //Assert
        Assert.Equal(10, node.Next.Value); // node1.Value
    }

    [Fact]
    public void NextNodeIsNullByDefault()
    {
        // Arrange
        var node = new SinglyLinkedListNode<int>(2);

        // Assert
        Assert.Null(node.Next);
    }

    [Fact]
    public void NextNodeCanBeSet()
    {
        // Arrange
        var node = new SinglyLinkedListNode<string>();
        var node1 = new SinglyLinkedListNode<string>();

        // Act
        node.Value = "hello";
        node.Next = node1;

        node.Next.Value = "world!";
        //node1.Value = "world!";


        //Assert
        Assert.Equal("world!", node1.Value); // node1.Value
    }

    [Fact]
    public void ToStringReturnsCorrectStringRepresentation()
    {
        var node = new SinglyLinkedListNode<double>(10.5);
        Assert.Equal("10,5", node.ToString());
    }

    [Fact]
    public void new_AddNode_Test()
    {
        var node = new SinglyLinkedListNode<int>(5);
        var node2 = new SinglyLinkedListNode<int>(15);

        node.Next = node2;

        Assert.Equal("5", node.ToString());
        Assert.Equal("15", node.Next.ToString());
    }
}