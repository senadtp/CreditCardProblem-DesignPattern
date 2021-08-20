using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreator factoryCreatorVisa = new FactoryCreator(new VisaFactory());
            factoryCreatorVisa.kartNo.kartNumarasi= "4555555555555555";
            factoryCreatorVisa.kartSahibi.kartSahibi= "İlayda";
            factoryCreatorVisa.sonKullanmaTarihi.kartSonKullanmaTarihi= "10.09.2024";
            Console.WriteLine(factoryCreatorVisa.kartNo.kartNumarasi);
            Console.WriteLine(factoryCreatorVisa.kartSahibi.kartSahibi);
            Console.WriteLine(factoryCreatorVisa.sonKullanmaTarihi.kartSonKullanmaTarihi);
            Console.ReadLine();

            FactoryCreator factoryCreatorMaster = new FactoryCreator(new MasterCardFactory());
            factoryCreatorMaster.kartNo.kartNumarasi = "5555555555555555";
            factoryCreatorMaster.kartSahibi.kartSahibi = "Sena";
            factoryCreatorMaster.sonKullanmaTarihi.kartSonKullanmaTarihi = "20.05.2022";
            Console.WriteLine(factoryCreatorMaster.kartNo.kartNumarasi);
            Console.WriteLine(factoryCreatorMaster.kartSahibi.kartSahibi);
            Console.WriteLine(factoryCreatorMaster.sonKullanmaTarihi.kartSonKullanmaTarihi);
            Console.ReadLine();

            FactoryCreator factoryCreatorAmerican = new FactoryCreator(new AmericanExpressFactory());
            factoryCreatorAmerican.kartNo.kartNumarasi = "341111111111111";
            factoryCreatorAmerican.kartSahibi.kartSahibi = "Ayşenur";
            factoryCreatorAmerican.sonKullanmaTarihi.kartSonKullanmaTarihi = "25.09.9999";
            Console.WriteLine(factoryCreatorAmerican.kartNo.kartNumarasi);
            Console.WriteLine(factoryCreatorAmerican.kartSahibi.kartSahibi);
            Console.WriteLine(factoryCreatorAmerican.sonKullanmaTarihi.kartSonKullanmaTarihi);
            Console.ReadLine();

        }
    }
}
