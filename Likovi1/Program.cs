using Likovi1;

static void IspisPodataka(params Lik[] likovi)
{
    foreach(Lik lik in likovi)
    {
        string info = String.Format("{0} povrsine {1} cm^2 "
            + "i opsega {2} cm",
            lik.Info, Math.Round(lik.Povrsina(),2),
            Math.Round(lik.Opseg(),2));
        Console.WriteLine(info);
    }
}

Lik[] likovi =
{
    new Kvadrat(3),
    new Pravokutnik(2.1,4),
    new Krug(4)
};
IspisPodataka(likovi);

object a = 1;
object b = "abeceda";
object c = new Kvadrat(5);

Stog stog = new Stog();
stog.Push(new Kvadrat(5));
stog.Push(new Pravokutnik(2, 3));
stog.Push(new Krug(2));
StogIspis(stog);
StogIspis(stog);

Stog intovi = new Stog();
intovi.Push(12);
int br = (int)intovi.Top;

int broj = 20;
object box = broj;
broj++;
Console.WriteLine($"{broj} {box}");
string podatak = broj.ToString();

static void StogIspis(Stog stog)
{
    Console.WriteLine("Ispis podataka sa stoga:");
    Stog pomocni = new Stog();
    while (!stog.JelPrazan)
    {
        pomocni.Push(stog.Top);
        Console.WriteLine(stog.Top);
        //IspisPodataka((Lik)stog.Top);
        stog.Pop();
    }
    while (!pomocni.JelPrazan)
    {
        stog.Push(pomocni.Top);
        pomocni.Pop();
    }
}

Lista lista = new Lista(new object[]
{
    new Krug(2),
    new Kvadrat(3)
});
for (Lista.Iterator it = lista.Begin(); it != lista.End(); ++it)
{
    IspisPodataka((Lik)it.Element);
}