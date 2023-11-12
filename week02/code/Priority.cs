/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario:  Enqueue three  items
        // Expected Result: Low (Pri:1), Medium (Pri:2), High (Pri:3)
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Low",1);
        priorityQueue.Enqueue("Medium",2);
        priorityQueue.Enqueue("High",3);
        Console.WriteLine(priorityQueue);
  

        // Defect(s) Found: No one

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Remove the item with the highest priority and return its value.
        // Expected Result: Low (Pri:1), Medium (Pri:2)
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low",1);
        priorityQueue.Enqueue("Medium",2);
        priorityQueue.Enqueue("High",3);
        
        
        Console.WriteLine(priorityQueue.Dequeue());

        Console.WriteLine(priorityQueue);



        // Defect(s) Found: needed the RemoveAt part and had a mistake in the for loop

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Having more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Low (Pri:1), Medium (Pri:2), High2 (Pri:3)
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low",1);
        priorityQueue.Enqueue("High1",3);
        priorityQueue.Enqueue("Medium",2);
        priorityQueue.Enqueue("High2",3);
        
        
        Console.WriteLine(priorityQueue.Dequeue());

        Console.WriteLine(priorityQueue);



                Console.WriteLine("---------");

        // Test 4
        // Scenario:  the queue is empty
        // Expected Result: error msg
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        
        
        Console.WriteLine(priorityQueue.Dequeue());



    }
}