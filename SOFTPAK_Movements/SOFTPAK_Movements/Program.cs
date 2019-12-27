using System;

namespace SOFTPAK_Movements
{
    class Program
    {
        static void Main(string[] args)
        {
            char Resp;
            char ListaCompo;
            string Marca;

            Console.Write("Deseja ver a lista de Produtos Disponíveis? [S/N]: ");
            Resp = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Que componente deseja ver? [P/G/M/S/H/F]: ");
            ListaCompo = char.Parse(Console.ReadLine().ToUpper());

            string Familia = determinarProduto(ListaCompo);
            Console.Write("Qual marca de {0} deseja ver?: ", Familia);
            Marca = Console.ReadLine().ToLower();

            listaProdutos(Resp, ListaCompo, Marca);
        }
        static void listaProdutos(char Resposta, char ListaCompo, string Marca)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var captcha = new String(stringChars);

            char Resp;
            string NomeProduto;
            char Com;

            if (Resposta == 'S')
            {
                if (ListaCompo == 'P')
                {
                    if (Marca == "intel")
                    {


                        Console.Clear();
                        Console.Write("Produtos disponíveis\n\n");
                        Console.Write(
                            "Processadores i3\n" +
                            "Intel Core i3-10110U\n" +
                            "Intel Core i3-10110Y\n" +
                            "Intel Core i3-1005G1\n" +
                            "Intel Core i3-9300T 9th Gen\n" +
                            "Intel Core i3-9300  9th Gen\n" +
                            "Intel Core i3-9100  9th Gen\n" +
                            "Intel Core i3-9100T 9th Gen\n" +
                            "Intel Core i3-9350K 9th Gen\n" +
                            "Intel Core i3-9320  9th Gen\n" +
                            "Intel Core i3-8145U 9th Gen\n" +
                            "Intel Core i3-8300\n" +
                            "Intel Core i3-8100T\n\n");
                        Console.Write(
                            "Processadores i5\n" +
                            "Intel Core i5-10210U 10th Gen\n" +
                            "Intel Core i5-10310Y 10th Gen\n" +
                            "Intel Core i5-10210Y 10th Gen\n" +
                            "Intel Core i5-9500   9th Gen\n" +
                            "Intel Core i5-9600   9th Gen\n" +
                            "Intel Core i5-9400   9th Gen\n" +
                            "Intel Core i5-9500T  9th Gen\n");

                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                            Console.Clear();
                    }
                    else if (Marca == "amd")
                    {
                        Console.Clear();
                        Console.Write("Produtos disponíveis\n\n");
                        Console.Write(
                            "AMD Ryzen 3 2300X\n" +
                            "AMD Ryzen 3 1300X\n" +
                            "AMD Ryzen 3 1200\n\n");
                        Console.Write(
                            "AMD Ryzen 5 3600X\n" +
                            "AMD Ryzen 5 3600\n" +
                            "AMD Ryzen 5 2600X\n" +
                            "AMD Ryzen 5 2600\n" +
                            "AMD Ryzen 5 2600E\n" +
                            "AMD Ryzen 5 2500X\n\n");
                        Console.Write(
                            "AMD Ryzen 7 3800X\n" +
                            "AMD Ryzen 7 3700X\n" +
                            "AMD Ryzen 7 2700\n" +
                            "AMD Ryzen 7 2700E\n" +
                            "AMD Ryzen 7 1800X\n\n");
                        Console.Write(
                            "AMD Ryzen 9 3950X\n" +
                            "AMD Ryzen 9 3900X\n\n");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                            Console.Clear();
                    }
                }
                else if (ListaCompo == 'G')
                {
                    if(Marca == "nvidia")
                    {
                        Console.Clear();
                        Console.Write("Produtos disponíveis\n\n");
                        Console.Write(
                            "NVidia Geforce RTX 2080 TI\n" +
                            "NVidia Geforce RTX 2060 Super\n" +
                            "NVidia Titan RTX\n" +
                            "NVidia Geforce GTX 1660TI\n" +
                            "Quadro RTX 6000\n" +
                            "GTX 1080 TI\n" +
                            "GTX 1070 TI\n" +
                            "GTX 1070\n" +
                            "GTX 1060 6GB\n" +
                            "GTX 1050 TI\n");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(Marca == "amd")
                    {
                        Console.Clear();
                        Console.Write("Produtos disponíveis\n\n");
                        Console.Write(
                            "AMD Radeon RX 570 4GB\n" +
                            "AMD Radeon RX 5700 XT\n" +
                            "AMD Radeon RX 590\n" +
                            "AMD Radeon RX 580 8GB\n" +
                            "AMD Radeon RX 570 4GB\n" +
                            "AMD Radeon RX 560 4GB");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (ListaCompo == 'M')
                {
                    if(Marca == "msi")
                    {
                        Console.Clear();
                        Console.Write(
                            "MSI - B360\n" +
                            "ATX MSI B450\n" +
                            "MSI Z390");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(Marca == "asus")
                    {
                        Console.Clear();
                        Console.Write(
                            "ATX Asus ROG Strix B360-F\n" +
                            "Ex-a320m\n" +
                            "ATX Asus TUF Z390-Plus\n" +
                            "B150 Pro SK1151\n" +
                            "Mb Amd B450 Skt\n" +
                            "Asus Rog Amd X399 Skt Tr4");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(Marca == "gigabyte")
                    {
                        Console.Clear();
                        Console.Write(
                            "ATX Gigabyte Aorus Elite\n" +
                            "Gigabyte B450M\n" +
                            "Micro-ATX B450M\n" +
                            "B360 D3H\n" +
                            "PbS1151-v2 Z390 Aorus Xtref");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if(ListaCompo == 'S')
                {
                    if(Marca == "kingston")
                    {
                        Console.Clear();
                        Console.Write(
                            "SSD 120GB Kingston A400\n" +
                            "SSD 240GB Kingston A400\n" +
                            "SSD 480GB Kingston A400\n" +
                            "SSD 960GB Kingston UV500 SATA3\n\n");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(Marca == "corsair")
                    {
                        Console.Clear();
                        Console.Write(
                            "SSD Corsair CSSD-N400 400GB\n" +
                            "SSD Corsair CSSD-F480 480GB\n" +
                            "SSD Corsair CSSD-F120 120GB\n\n");
                        Console.Write("\nDeseja adquirir algum? [s/n]: ");
                        Resp = char.Parse(Console.ReadLine().ToLower());
                        if (Resp == 's')
                        {
                            Console.WriteLine("\nDigite o nome do produto que deseja adquirir [Digite -cancelar para cancelar o processo]");
                            NomeProduto = Console.ReadLine();
                            if (NomeProduto == "-cancelar")
                            {
                                Console.Clear();
                                Console.WriteLine("Processo cancelado.");
                            }
                            else
                            {
                                string Confirmar = "";
                                string Metodo = "";
                                string Email = "";
                                string Password = "";

                                Console.Clear();
                                Console.WriteLine();
                                Console.Write(captcha);
                                Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                Console.Write("-> ");
                                Confirmar = Console.ReadLine();

                                if (Confirmar == captcha)
                                {
                                    Console.Write("Métodos de pagamento disponíveis:\n");
                                    Console.WriteLine("-> PayPal\n-> MBway");
                                    Console.Write("Método de pagamento que deseja utilizar: ");
                                    Metodo = Console.ReadLine().ToLower();
                                    if (Metodo == "paypal")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("========== Login ==========\n");
                                        Console.Write("Email: ");
                                        Email = Console.ReadLine();
                                        while (!Email.Contains("@"))
                                        {
                                            Console.Clear();
                                            Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                            Console.WriteLine("========== Login ==========\n");
                                            Console.Write("Email: ");
                                            Email = Console.ReadLine();
                                        }
                                        Console.Write("Senha: ");
                                        Password = Console.ReadLine();

                                        Console.Clear();
                                        Fatura(NomeProduto, Metodo);
                                        Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                             "Deseja adicionar algum comentário? [S/N]");
                                        Com = char.Parse(Console.ReadLine().ToLower());
                                        if (Com == 's')
                                        {
                                            string Comentario;
                                            Console.Write("Escreva o seu comentário:\n" +
                                                "-> ");
                                            Comentario = Console.ReadLine();

                                            enviarComentsERecla(Comentario);
                                        }
                                    }
                                }
                                else
                                {
                                    while (Confirmar != captcha)
                                    {

                                        Console.WriteLine("Opps!...");
                                        Console.WriteLine("Você não acertou o captcha, tente novamente.");
                                        Console.WriteLine();
                                        Console.Write(captcha);
                                        Console.Write("\nConfirme a compra digitando o captcha acima!\n");
                                        Console.Write("-> ");
                                        Confirmar = Console.ReadLine();
                                        if (Confirmar == captcha)
                                        {
                                            Console.Write("Métodos de pagamento disponíveis:\n");
                                            Console.WriteLine("-> PayPal\n-> MBway");
                                            Console.Write("Método de pagamento que deseja utilizar: ");
                                            Metodo = Console.ReadLine().ToLower();
                                            if (Metodo == "paypal")
                                            {
                                                Console.Clear();
                                                Console.WriteLine("========== Login ==========\n");
                                                Console.Write("Email: ");
                                                Email = Console.ReadLine();
                                                while (!Email.Contains("@"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("===========================================================\n" +
                                                                    "Opps! Parece que o seu email não é válido. Tente novamente.\n" +
                                                                    "============================================================\n");
                                                    Console.WriteLine("========== Login ==========\n");
                                                    Console.Write("Email: ");
                                                    Email = Console.ReadLine();
                                                }
                                                Console.Write("Senha: ");
                                                Password = Console.ReadLine();

                                                Console.Clear();
                                                Fatura(NomeProduto, Metodo);
                                                Console.WriteLine("\nObrigado por escolher a SOFTPAK!\n" +
                                            "Deseja adicionar algum comentário? [S/N]");
                                                Com = char.Parse(Console.ReadLine().ToLower());
                                                if (Com == 's')
                                                {
                                                    string Comentario;
                                                    Console.Write("Escreva o seu comentário:\n" +
                                                        "-> ");
                                                    Comentario = Console.ReadLine();

                                                    enviarComentsERecla(Comentario);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static string determinarProduto(char LetraEscolhida)
        {
            string Familia = "";
            switch (LetraEscolhida)
            {
                case 'P':
                    Familia = "Processadores";
                    break;
                case 'G':
                    Familia = "Placas gráficas";
                    break;
                case 'M':
                    Familia = "Motherboard's";
                    break;
                case 'S':
                    Familia = "SSD's";
                    break;
                case 'H':
                    Familia = "HD's";
                    break;
                case 'F':
                    Familia = "Fontes de alimentação";
                    break;
            }
            return Familia;
        }
        static void Fatura(string NomeProduto, string Metodo)
        {
            DateTime DataAtual = DateTime.Now;
            Console.WriteLine("========== Fatura ==========");
            Console.Write("\nProduto -> {0}\n", NomeProduto);
            Console.Write("\nPreço   -> 65$\n");
            Console.Write("\nMétodo  -> {0}", Metodo);
            Console.Write("\n\nSOFTPAK ELETRONICS\n\n");
            Console.WriteLine(DataAtual);
        }
        static void enviarComentsERecla(string Texto)
        {
            Console.WriteLine("O seu comentário foi enviado com sucesso!\n" +
                "Pré-visualização:\n" +
                "-> {0}", Texto);
        }
    }
}