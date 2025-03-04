To run project az-iao-quickstart follow this steps:<br />
cd az-oai-quickstart<br />
dotnet build<br />
dotnet add package Azure.AI.OpenAI<br />
dotnet add package OpenAI.Chat<br />
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_API_KEY', [key], 'User')<br />
[System.Environment]::SetEnvironmentVariable('AZURE_OPENAI_ENDPOINT', [endpoint], 'User')<br />
dotnet run<br />

AI Foundry Chat App - az-fndry-quickstart folder<BR/>
  Qick start link: https://learn.microsoft.com/en-us/azure/ai-foundry/quickstarts/get-started-code?tabs=windows<BR/>
	Setting environment<BR/>
    .venv\scripts\activate <BR/>
		#if error follow next two lines<BR/>
			py -3 -m venv .venv<BR/>
			.venv\scripts\activate<BR/>
    pip install azure-ai-projects azure-ai-inference azure-identity<BR/>
		open powershell seprate window<BR/>
			winget install -e --id Microsoft.AzureCLI<BR/>
			az login<BR/>
			python chat.py<BR/>
