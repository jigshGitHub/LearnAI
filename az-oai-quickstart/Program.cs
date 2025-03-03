// See https://aka.ms/new-console-template for more information
using System;
using Azure.AI.OpenAI;
using System.ClientModel;
using OpenAI.Chat;
using static System.Environment;

internal class Program
{
    private static void Main(string[] args)
    {
        string? endpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        string? key = GetEnvironmentVariable("AZURE_OPENAI_API_KEY");
        string? chatModel = "gpt-35-turbo";

        AzureOpenAIClient azOAIClient = new AzureOpenAIClient(new Uri(endpoint), new ApiKeyCredential(key));

        ChatClient chatClient = azOAIClient.GetChatClient(chatModel);
       Console.WriteLine(endpoint);
       Console.WriteLine(key);
/*
        ChatCompletion completion = chatClient.CompleteChat(
            [
                new SystemChatMessage("You are a helpful assistant that talks like a pirate."),
        new UserChatMessage("Does Azure OpenAI support customer managed keys?"),
        new AssistantChatMessage("Yes, customer managed keys are supported by Azure OpenAI"),
        new UserChatMessage("Do other Azure AI services support this too?"), new UserChatMessage("Can you explain what is bollywood?"),
            ]);

        Console.WriteLine($"{completion.Role}: {completion.Content[0].Text}");
        */
        Console.WriteLine("A recipe generator:");
        Console.Write("How many recipes do you want?:");
        int numberOfRecipes = int.Parse(Console.ReadLine());
        Console.Write("Provide the list of ingredients you have:");
        string ingredients = Console.ReadLine();
        Console.Write("Provide dietry restrictions if any:");
        string filter = Console.ReadLine();

        string prompt = string.Format("Show me {0} recipes for a dish with following ingredients: {1}. Per recipe, list all the ingredients used, except {2}:",numberOfRecipes,ingredients,filter);
        ChatCompletion completion = chatClient.CompleteChat([
                new SystemChatMessage("You are a helpful assistant that talks like a pirate."),
        new UserChatMessage("Does Azure OpenAI help any recipes?"),
        new AssistantChatMessage("Yes, just let me know what do you want?"),
        new UserChatMessage(prompt),
            ]);

             Console.WriteLine($"{completion.Role}: {completion.Content[0].Text}");

    }
}