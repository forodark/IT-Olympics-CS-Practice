//The Vigenère cipher is a polyalphabetic cipher because it uses two or more cipher alphabets to encrypt the data. In other
//words, the letters in the Vigenère cipher are shifted by different amounts, normally done using a word or phrase as the
//encryption key .

using System;

class Difficult2 {
    	public static void Main() {
        	Console.Write("Enter key: ");
        	string key = Console.ReadLine();

        	Console.Write("Enter plaintext: ");
        	string plaintext = Console.ReadLine();

        	string ciphertext = "";
        	int[] number_key = new int[key.Length];

        	for (int i = 0; i < key.Length; i++) {
            		number_key[i] = key[i] - 'A';
        	}	

        	for (int i = 0; i < plaintext.Length; i++) {
            		char c = Encrypt(plaintext[i], number_key[i % key.Length]);
            		ciphertext += c;
        	}

        	Console.WriteLine("Ciphertext: " + ciphertext);
    	}

    	static char Encrypt(char plainChar, int shift) {
        	if (char.IsLetter(plainChar)) {
            		char offset = char.IsUpper(plainChar) ? 'A' : 'a';
            		return (char)((plainChar + shift - offset) % 26 + offset);
        	}
       	 	return plainChar;
    	}
}