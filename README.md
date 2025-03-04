To run project az-iao-quickstart follow this steps:<br />
cd az-oai-quickstart<br />
dotnet build<br />
dotnet add package Azure.AI.OpenAI<br />
dotnet add package OpenAI.Chat<br />
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_API_KEY', [key], 'User')<br />
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_ENDPOINT', [endpoint], 'User')<br />
dotnet run<br />
