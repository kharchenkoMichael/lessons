using System;


using Lesson1;

var convertor = new Converter(42.30, 41.35);

Console.WriteLine($"100$ = {convertor.GetHrnFromUsd(100)}hrn");
Console.WriteLine($"1000hrn = {convertor.GetUsdFromHrn(1000)}$");
Console.WriteLine($"100eur = {convertor.GetHrnFromEur(100)}hrn");
Console.WriteLine($"1000hrn = {convertor.GetEurFromHrn(1000)}eur");