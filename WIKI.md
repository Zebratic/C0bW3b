<img src="https://github.com/Zebratic/C0bW3b/blob/main/imgs/banner.png?raw=true"/>

# Installation
1. Head over to the releases and download the latest build.

## Or alternatively:
1. Make sure you have installed the `.NET Framework 4.8`.
2. **Clone this repository** and open the solution file with Visual Studio. Preferebly `Visual Studio Community 2022`.
3. Switch to **Release** mode for a much cleaner output.
4. **Build** the solution (Visual Studio will fetch all the missing nuget packages).
5. You can find the executable inside the folders `C0bW3b/bin/Release`

# Quick Guide
1. Install the software as shown above
2. Create a dork list, this is a list of search terms that contains ``%ITEM%``.
(WIP from here)





# Usage
## Lists
There is 3 different type of lists:
- Dorks
  - A Dork list is the terms that C0bW3b will use to search for sites, its practically what it will search for.
- Matches
  - A Match list is what all the result sites that are found will be checked against.
  - Match lists can also be a list of regex expresions, just make sure to check `Matches is regex` option.
  - An example would be if a site has some text where it says `Buy Now`, and you have that exact text in your match list, it will flag that site as a Hit.
- Proxies
  - A Proxy list is simple, you would have a list of proxies which would be used to search around the web with.
  - Proxy formats that are supported are `IP:PORT` and `IP:PORT:USER:PASS`.
  - Alternatively, you can still find hits easily without proxies. *(Proxies are not needed)*

## Runner Settings
C0bW3b has many settings that can help find your target more specifically.
Such as:
- Target Search
  - You can use the `%ITEM%` tag in both your Dork and Match list to replace it with whatever is inputted in the Target text field.
- Regex Matches
  - You can use **Regular Expressions** in your Match list to find specific results.
  - To use Regex Matches, make sure you enable the feature on the side panel before starting.
  - By having Regex Matches enabled, it will read your Match list as a list of **Regular Expressions**. (Using this setting without any Regex's will give no results)
  - [View more about Regex here](https://cs.lmu.edu/~ray/notes/regex/)
- Proxyless
  - Use this if you dont have proxies to use, or you just want to run on your current IP address.
- Threads
  - This number means how many simultanious searches the software can do at a time, the more threads, the faster results.
- Allow Duplicates
  - This setting will allow duplicate results, if for an example, the software finds the same url, it will still check it, even though it has already been checked.
- Log Full URL
  - This setting will save the whole url that was found, so instead of having the root url as: `https://website.com/` it will log is as `https://website.com/somedirectory/somewebpage.php` etc.
- Min Matches
  - This number means how many matches are required for a site to be marked as a hit.
  - If this number is higher than the lines in your **Matches List**, it will never mark anything as a hit, obviously.
- Recursive Search
  - This setting will allow the software to go deep into a site, and routing through other URLs that direct to other sites, to check those aswell as the original URL.
- Recursive Limit
  - This number is the limit of how deep into the found urls the software is allowed to go, so it wont go indefinitely deep into a site.
- URL Limit
  - This number is the limit of how many links the software can maximum gather in a recursive search. (*This is to prevent mass spam of random links*) 

## Other Settings
- Theming
  - (*Theming is currently not available to change from within the software, however **SOME** values are able to be changed directly from the config*) > However, this is not recommended
- General
  - Update Thread Status
    - This setting will allow you to **disable** updating the threads status on the **Runner's tab**. (*This can improve performance on some systems, or on big deep searches*)
  - Auto Save
    - This setting will allow the software to automatically save your settings with a set interval.
  - Auto Save Interval
    - This value will determine the Auto Save interval in seconds.
- Output
  - Output Format
    - This is the variables that will be printed in the **output log**, that is displayed on the **Runner's tab**. You can also rearrange the variables by drag-dropping to your liking.
  - Seperator
    - This string of text is what gets printed in between the selected variables in the **Output Format**.

## Engine Settings
- You can add your own custom search engines on this tab by inputting a search url containing the string ``%DORK%`` where the current dork would be injected at.
  - An example would be ``https://www.google.com/search?q=%DORK%`` as the Search URL.
  - For the URL regex, the default for most sites would be ``<a href="(.*?)">`` where it would get the value inside the ``<a>`` tag at the href variable.
  - Left and right string is a piece of text from the html response that will define exactly at what place the software can find the results.
    - If you dont know what this means, just leave both blank.
