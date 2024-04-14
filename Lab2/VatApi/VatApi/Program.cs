using VatApi;

ApiVatFetcher apiVatFetcher = new ApiVatFetcher();
string resultFetcher = apiVatFetcher.getDataFromGivenNip("5260309174");
Console.WriteLine(resultFetcher);


ViesApproximateDeseralizer vies = new ViesApproximateDeseralizer();

Vat vat = vies.deseralizeStudents(resultFetcher);

Console.WriteLine(vat);

