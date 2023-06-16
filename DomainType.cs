namespace code_signal;

public static class DomainType
{
    // label the domain end "commercial", "organization", "network" or "iformation"
    //                       .com          .org            .net         .net
    // in order to do that we can use a dictionary

    // return an array of domains(solution)
    public static string[] solution(string[] domains)
    {
        string[] labels = new string[domains.Length];

        Dictionary<string, string> domainsLabels = new Dictionary<string, string>
        {
            {"com", "commercial"},
            {"org", "organization"},
            {"net", "network"},
            {"info", "iformation"},
        };

        for (int i = 0; i < domains.Length; i++)
        {
            var currentDomain = domains[i];
            var indexDomain = domains[i].LastIndexOf('.');
            string domainId = domains[i].Substring(indexDomain + 1, domains[i].Length - indexDomain - 1);

            if (domainsLabels.TryGetValue(domainId, out string value))
                labels[i] = value;
        }
        return labels;
    }
}
