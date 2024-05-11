using EncryptDecrypt;

//Get Message
Console.WriteLine("Write your message");
string? myMessage = Console.ReadLine();
Console.Clear();

//Encrypt Message
string encryptMessage = Level1.Encrypt(myMessage);
Console.WriteLine("Encrypted: " + encryptMessage);
Console.WriteLine();
Console.WriteLine("Decrypting...press enter");
Console.ReadLine();
//Decrypt Message
string decryptMessage = Level1.Decrypt(encryptMessage);
Console.WriteLine("Decrypted: " + decryptMessage);

