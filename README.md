To run project az-iao-quickstart follow this steps:
cd az-oai-quickstart
dotnet build
dotnet add package Azure.AI.OpenAI
dotnet add package OpenAI.Chat
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_API_KEY', [key], 'User')
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_ENDPOINT', [endpoint], 'User')
dotnet run
