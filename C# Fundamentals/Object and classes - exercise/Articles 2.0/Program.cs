using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles 2.0
{
    class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Article> articles = new List<Article>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);
            articles.Add(article);
        }
        string criteria = Console.ReadLine();
        if (criteria == "title")
        {
            articles.OrderBy(x => x.Title);
        }
        else if (criteria == "content")
        {
            articles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
        }
        else if (criteria == "author")
        {
            articles.OrderBy(x => x.Author);
        }
        Console.WriteLine(articles);
    }
}
class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
