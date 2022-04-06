# dotnet_build_snafu

A proof-of-concept build that should launch a http server on localhost for WebDriver testing purposes. 
It should, I think, based on reading I've done, but it is not 'up' when WebDriver attempts to GET the index page.

## Setup:

1. DotNet 6 SDK
2. Chrome the browser
2. chromedriver.exe needed (`choco install chromedriver`)

## Eyeball Test:

Launch Program.cs in your IDE and visit http://localhost:7171

## Automated Test:

```
dotnet test
```

Should fail. Well I mean it shouldn't fail, but does.  I'm missing a line somewhere.

Error in the log:  OpenQA.Selenium.WebDriverException : unknown error: net::ERR_CONNECTION_REFUSED

The test should pass - the WebDriver instance should reach the server and confirm the title of the page. 
If you add a 10 second delay before WebDriver looks for the page, it still gets ERR_CONNECTION_REFUSED