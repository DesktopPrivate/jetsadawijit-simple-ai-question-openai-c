using OpenAI;
using System;

namespace SimpleQABot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with your OpenAI API key
            string apiKey = "";

            OpenAIAPI openai = new OpenAIAPI(apiKey);

            while (true)
            {
                Console.WriteLine("Ask your question (or 'exit' to quit):");
                string question = Console.ReadLine();

                if (question.ToLower() == "exit")
                {
                    break;
                }

                var completion = openai.Completion.Create(
                    engine: "text-davinci-003",
                    prompt = question,
                    maxTokens: 100,
                    n: 1,
                    stop: null,
                    temperature: 0.7
                );

                Console.WriteLine("Answer: {0}", completion.Choices[0].Text.Trim());
            }
        }
    }
}
