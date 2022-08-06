using System;
using System.Collections.Generic;

namespace numerosExtensos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Funções por Extenso"
            static string extenseUnidade(string unidade, string dezena)
            {
                if (dezena == "1")
                {
                    switch (unidade)
                    {
                        case "1":
                            unidade = "onze ";
                            break;

                        case "2":
                            unidade = "doze ";
                            break;

                        case "3":
                            unidade = "treze ";
                            break;

                        case "4":
                            unidade = "quatorze ";
                            break;

                        case "5":
                            unidade = "quinze ";
                            break;

                        case "6":
                            unidade = "dezesseis ";
                            break;

                        case "7":
                            unidade = "dezessete  ";
                            break;

                        case "8":
                            unidade = "dezoito ";
                            break;

                        case "9":
                            unidade = "dezenove ";
                            break;

                        default:
                            break;
                    }
                    return unidade;
                }
                    switch (unidade)
                    {
                        case "1":
                            unidade = "um ";
                            break;

                        case "2":
                            unidade = "dois ";
                            break;

                        case "3":
                            unidade = "três ";
                            break;

                        case "4":
                            unidade = "quatro ";
                            break;

                        case "5":
                            unidade = "cinco ";
                            break;

                        case "6":
                            unidade = "seis ";
                            break;

                        case "7":
                            unidade = "sete ";
                            break;

                        case "8":
                            unidade = "oito";
                            break;

                        case "9":
                            unidade = "nove ";
                            break;

                        default:
                            break;
                    }
                return unidade;
            }

            static string extenseDezena(string dezena, string unidade)
            {
                if (dezena == "0")
                {
                    return "";
                }
                switch (dezena)
                {
                    case "1":
                        if (unidade == "0")
                        {
                            dezena = "dez";
                        }
                        else
                        {
                            dezena = "";
                        }
                        break;

                    case "2":
                        dezena = "vinte ";
                        break;

                    case "3":
                        dezena = "trinta ";
                        break;

                    case "4":
                        dezena = "quarenta ";
                        break;

                    case "5":
                        dezena = "cinquenta ";
                        break;

                    case "6":
                        dezena = "sessenta ";
                        break;

                    case "7":
                        dezena = "setenta ";
                        break;

                    case "8":
                        dezena = "oitenta ";
                        break;

                    case "9":
                        dezena = "noventa ";
                        break;

                    default:
                        dezena = "";
                        break;
                }
                if (unidade != "0" && dezena != "0")
                {
                    if (dezena == "0")
                    {
                        dezena = "e ";
                    }
                    else
                    {
                        dezena += "e ";
                    }
                }
                return dezena;
            }

            static string extenseCentena(string centena, string dezena, string unidade)
            {
                if (centena == "0")
                {
                    return "";
                }
                if (dezena != "0" || unidade != "0")
                {
                    if (centena == "1")
                    {
                        centena = "cento ";
                        if (unidade != "0" || dezena != "0")
                        {
                            centena += "e ";
                        }
                        return centena;
                    }
                }
                switch (centena)
                {
                    case "1":
                        centena = " e cem";
                        break;

                    case "2":
                        centena = "duzentos ";
                        break;

                    case "3":
                        centena = "trezentos ";
                        break;

                    case "4":
                        centena = "quatrocentos ";
                        break;

                    case "5":
                        centena = "quinhentos ";
                        break;

                    case "6":
                        centena = "seiscentos ";
                        break;

                    case "7":
                        centena = "setecentos ";
                        break;

                    case "8":
                        centena = "oitocentos ";
                        break;

                    case "9":
                        centena = "novecentos ";
                        break;

                    default:
                        centena = "";
                        break;
                }
                if (unidade != "0" || dezena != "0")
                {
                    centena += "e ";
                }
                return centena;
            }

            static string extenseUnidadeMilhar(string unidadeMilhar, string dezenaMilhar)
            {
                if (unidadeMilhar == "0")
                {
                    return "";
                }
                unidadeMilhar = extenseUnidade(unidadeMilhar, dezenaMilhar) + "mil ";
                return unidadeMilhar;
            }

            static string extenseDezenaMilhar(string dezenaMilhar, string unidadeMilhar)
            {
                if (dezenaMilhar == "0")
                {
                    return "";
                }
                dezenaMilhar = extenseDezena(dezenaMilhar, unidadeMilhar);
                return dezenaMilhar;
            }

            static string extenseCentenaMilhar(string centenaMilhar, string dezenaMilhar, string unidadeMilhar)
            {
                if (centenaMilhar == "0")
                {
                    return "";
                }
                centenaMilhar = extenseCentena(centenaMilhar, dezenaMilhar, unidadeMilhar);
                return centenaMilhar;
            }

            static string extenseUnidadeMilhonar(string unidadeMilhonar, string dezenaMilhonar)
            {
                if (unidadeMilhonar == "0")
                {
                    return "";
                }
                if (unidadeMilhonar == "1")
                {
                    unidadeMilhonar = extenseUnidade(unidadeMilhonar, dezenaMilhonar) + "milhão ";
                    return unidadeMilhonar;
                }
                unidadeMilhonar = extenseUnidade(unidadeMilhonar, dezenaMilhonar) + "milhões ";
                return unidadeMilhonar;
            }

            static string extenseDezenaMilhonar(string dezenaMilhonar, string unidadeMilhonar)
            {
                if (dezenaMilhonar == "0")
                {
                    return "";
                }
                dezenaMilhonar = extenseDezena(dezenaMilhonar, unidadeMilhonar);
                return dezenaMilhonar;
            }

            static string extenseCentenaMilhonar(string centenaMilhonar, string dezenaMilhonar, string unidadeMilhonar)
            {
                if (centenaMilhonar == "0")
                {
                    return "";
                }
                centenaMilhonar = extenseCentena(centenaMilhonar, dezenaMilhonar, unidadeMilhonar);
                return centenaMilhonar;
            }

            static string extenseUnidadeBilhar(string unidadeBilhar)
            {
                if (unidadeBilhar == "0")
                {
                    return "";
                }
                else if (unidadeBilhar != "1")
                {
                    unidadeBilhar = extenseUnidade(unidadeBilhar, "0") + "bilhões ";
                    return unidadeBilhar;
                }
                unidadeBilhar = extenseUnidade(unidadeBilhar, "0") + "bilhão ";
                return unidadeBilhar;
            }

            #endregion

            Console.Write("Insira um número inteiro: ");
            string num = Console.ReadLine();
            Console.Write("Por extenso: ");
            List<char> arrayNum = new List<char>();
            for (int i = 0; i < num.Length; i++)
            {
                arrayNum.Add(num[i]);
            }
            string[] extenseNum = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            int j = 9;
            for (int i = arrayNum.Count - 1; i >= 0; i--)
            {
                extenseNum[j] = (arrayNum[i]).ToString();
                j--;
            }
            extenseNum.SetValue(extenseUnidade(extenseNum[9], extenseNum[8]), 9);
            extenseNum.SetValue(extenseDezena(extenseNum[8], extenseNum[9]), 8);
            extenseNum.SetValue(extenseCentena(extenseNum[7], extenseNum[8], extenseNum[9]), 7);
            extenseNum.SetValue(extenseUnidadeMilhar(extenseNum[6], extenseNum[7]), 6);
            extenseNum.SetValue(extenseDezenaMilhar(extenseNum[5], extenseNum[6]), 5);
            extenseNum.SetValue(extenseCentenaMilhar(extenseNum[4], extenseNum[5], extenseNum[6]), 4);
            extenseNum.SetValue(extenseUnidadeMilhonar(extenseNum[3], extenseNum[2]), 3);
            extenseNum.SetValue(extenseDezenaMilhonar(extenseNum[2], extenseNum[3]), 2);
            extenseNum.SetValue(extenseCentenaMilhonar(extenseNum[1], extenseNum[2], extenseNum[3]), 1);
            extenseNum.SetValue(extenseUnidadeBilhar(extenseNum[0]), 0);
            foreach (string lista in extenseNum)
            {
                if (lista != "0")
                {
                    Console.Write(lista);
                }
            }
            Console.ReadKey();
        }
    }
}
