

namespace ConsoleApp7;

internal class Question
{

    public static void q1()
    {
        Console.WriteLine("Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.\r\n    interface :hiding the complexity details and showing only the essential information , it defines  what a system can do (defining what not how )\r\n, because it provides able to be growing    , loose coupling instead of tight coupling , we can work as teamwork without wasting time ,also there are benefits such as \r\n1-protected from change , The biggest advantage of using an interface to achieve OCP  is that it completely eliminates the need for massive if/else or switch statements when your system grows.\r\n2-Powerful Polymorphism\r\n3-loose coupling");
    }


    public static void q2()
    {
        Console.WriteLine("2-\r\na-The Problem: Interface Method Collision ,the class have to use Implicit Interface Implementation.Because the methods share the same name and signature, standard Implicit Interface Implementation forces the class to use a single, shared method to satisfy both interfaces.\r\nb-interface IEnglishSpeaker\r\n{\r\n    void Greet();\r\n}\r\n\r\ninterface IArabicSpeaker\r\n{\r\n    void Greet();\r\n}\r\n\r\nclass Translator : IEnglishSpeaker, IArabicSpeaker\r\n{\r\n    void IEnglishSpeaker.Greet()\r\n    {\r\n        Console.WriteLine(\" Ahlen\");\r\n    }\r\n\r\n\r\n    void IArabicSpeaker.Greet()\r\n    {\r\n        Console.WriteLine(\"Hello \");\r\n    }\r\n\r\n} \r\nthe technique is called  implicit interface  implementation   \r\n\r\nc-I cannot call Greet() directly on a Translator object because it will result in a compile-time error. Instead, we must use a reference to either IEnglishSpeaker or IArabicSpeaker to indicate to the compiler exactly which method we are calling.\r\n\r\n");
    }
    public static void q3()
    {
        Console.WriteLine("A Shallow Copy copies:\r\n\r\nThe values of Value Types\r\n\r\nThe memory addresses of Reference Types\r\n\r\nBut it does NOT copy the actual objects that those references point to.\r\n\r\n shared memory\r\n\r\n shared references\r\n\r\nA Deep Copy copies:\r\n\r\nThe values\r\n\r\nThe references\r\n\r\nThe actual objects behind those references\r\n\r\nNo shared memory\r\n\r\nNo shared references\r\n\r\nYou use a shallow copy when:\r\n\r\nThe object contains only value types\r\n\r\nOr reference-type fields are immutable (like string)\r\n\r\n\r\nExample use case:\r\nCaching scenarios\r\n\r\nWhen to Use Deep Copy\r\n\r\nYou use a deep copy when:\r\n\r\nThe object contains mutable reference types\r\nYou want to avoid side effects\r\nyou want to modification without affecting the orginal object \r\n\r\n\r\nExample use case:\r\nCloning domain models\r\nMultithreaded scenarios\r\n\r\nWhat Is the Risk of Using a Shallow Copy When the Object Has Reference-Type Fields?\r\n\r\nThe main risk is:\r\n\r\nUnintended shared state\r\n\r\nBecause shallow copy copies the reference, not the object itself.\r\n\r\nSo both objects point to the same memory location.\r\n\r\n\r\n\r\n\r\n\r\nShallow Copy is suitable when objects contain only value types or immutable references.\r\n\r\nDeep Copy is necessary when objects contain mutable reference types and full independence is required.\r\n\r\nThe risk of shallow copy is unintended shared state, leading to side effects, hidden bugs, and potential concurrency issues.\r\n\r\n\r\n\r\n");


    }

     public static void q4()
    {
        Console.WriteLine("Output: Dev - Testing\r\nQA - Testing   Title is a string (immutable).\r\n\r\nAssigning \"QA\" creates a new string reference.\r\n\r\nSo e1.Title remains \"Dev\".");

    }

}

