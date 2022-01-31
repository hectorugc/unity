public class Message {
    public void Print(){
        Console.WriteLine("Bonnjour Monde");
    }
}


class Program {
    static void Main(){
        Message hiMessage = new Message();
        hiMessage.Print();
    }
}