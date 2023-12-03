using Oefeningen_tekstbestanden;

Menu menu = new Menu();

menu.AddOption('1', "Oefening 1", oef1);
menu.AddOption('2', "Oefening 2", oef2);
menu.AddOption('3', "Oefening 3", oef3);
menu.AddOption('4', "Oefening 4", oef4);
menu.AddOption('5', "Oefening 5", oef5);
menu.AddOption('6', "Oefening 6", oef6);

menu.Start();

static void oef1()
{
    var oefening = new Oefening1();
    oefening.ReadAndPrint();
}

static void oef2()
{
    var oefening = new Oefening2();
    oefening.ReadAndCompare();
}

static void oef3()
{
    var oefening = new Oefening3();
    oefening.FillList();
    oefening.WriteList();
}

static void oef4()
{
    var oefening = new Oefening4();
    oefening.InputToFile();
}

static void oef5()
{
    var oefening = new Oefening5();
    oefening.DoesExist();
}

static void oef6()
{
    var oefening = new Oefening6();
    oefening.Run();
}
