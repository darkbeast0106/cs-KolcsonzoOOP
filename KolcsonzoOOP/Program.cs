using KolcsonzoOOP;

List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
Konyv konyv1 = new Konyv("The Fellowship of the Ring", "J. R. R. Tolkien", "IS-1234");
Konyv konyv2 = new Konyv("A Song of Ice and Fire", "George R. R. Martin", "IS-1234");
Konyv konyv3 = new Konyv("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "IS-1234");
Dvd dvd1 = new Dvd("The Lord of the Rings: The Fellowship of the Ring", 178);
Dvd dvd2 = new Dvd("The Lord of the Rings: The Return of the King", 201);
Dvd dvd3 = new Dvd("The Lord of the Rings: The Two Towers", 179);
Dvd dvd4 = new Dvd("Star Wars: Episode IV - A New Hope", 121);
Dvd dvd5 = new Dvd("Star Wars: Episode V - The Empire Strikes Back", 124);
Dvd dvd6 = new Dvd("Star Wars: Episode VI - Return of the Jedi", 131);
Ujsag ujsag1 = new Ujsag("Képes Sport", 2007, 23);
Ujsag ujsag2 = new Ujsag("Képes Sport", 2007, 24);
Ujsag ujsag3 = new Ujsag("Képes Sport", 2007, 25);
Ujsag ujsag4 = new Ujsag("Képes Sport", 2007, 26);

katalogus.Add(konyv1);
katalogus.Add(konyv2);
katalogus.Add(konyv3);
katalogus.Add(dvd1);
katalogus.Add(dvd2);
katalogus.Add(dvd3);
katalogus.Add(dvd4);
katalogus.Add(dvd5);
katalogus.Add(dvd6);
katalogus.Add(ujsag1);
katalogus.Add(ujsag2);
katalogus.Add(ujsag3);
katalogus.Add(ujsag4);

foreach (var item in katalogus)
{
    Console.WriteLine(item.MegjelenitendoNev());
	if (item is Konyv)
	{
		Console.WriteLine("\t"+((Konyv)item).Isbn);
	}
}

Console.WriteLine();

List<Dvd> dvdk = new List<Dvd>();
dvdk.Add(dvd1);
dvdk.Add(dvd2);
dvdk.Add(dvd3);
dvdk.Add(dvd4);
dvdk.Add(dvd5);
dvdk.Add(dvd6);
foreach (var item in dvdk)
{
	Console.WriteLine(item.MegjelenitendoNev());
}

Console.WriteLine();
dvdk.Sort();
foreach (var item in dvdk)
{
    Console.WriteLine(item.MegjelenitendoNev());
}