int[,] mat = new int[5, 5]; 
int l, c, soma = 0;
Console.WriteLine("Insira 9 valores para a matriz:"); 
for (l = 0; l < 5; l++) { for (c = 0; c < 5; c++) {
        Console.WriteLine("Informe o valor do indice " + l + " , " + c);
        mat[l, c] = Convert.ToInt32(Console.ReadLine()); 
    } }
for (l = 0; l < 5; l++) { 
    for (c = 0; c < 5; c++) 
    { if (l < c) { 
            Console.WriteLine("Elementos acima" + mat[l, c]); } 
        if (l > c) { Console.WriteLine("Elementos abaixo" + mat[l, c]); } } }