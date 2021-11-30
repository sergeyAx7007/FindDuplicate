int FindDuplicate(List<string> name, List<int> price, List<int> weight)
{

	if (name.Count == price.Count && price.Count == weight.Count)
	{
		List<object[]> products = new List<object[]>();
		for (int i = 0; i < name.Count; i++)
		{
			products.Add(new object[] { name[i], price[i], weight[i] });
		}
		var count = products
			.GroupBy(x => new { Name = x[0], Price = x[1], Weight = x[2] })
			.Select(x => new { Prod = x, Count = x.Count() - 1 })
			.Where(x => x.Count > 0)
			.Sum(x => x.Count);
		return count;
	}
	throw new Exception("Different length of lists");
}