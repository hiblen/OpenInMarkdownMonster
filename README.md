[AppVeyorProjectUrl]: https://ci.appveyor.com/project/GregTrevellick/openinmarkdownmonster
[AppVeyorProjectBuildStatusBadgeSvg]: https://ci.appveyor.com/api/projects/status/smnm0umu798i7jk5?svg=true
[GitHubRepoURL]: https://github.com/GregTrevellick/OpenInMarkdownMonster
[GitHubRepoIssuesURL]: https://github.com/GregTrevellick/OpenInMarkdownMonster/issues
[GitHubRepoPullRequestsURL]: https://github.com/GregTrevellick/OpenInMarkdownMonster/pulls
[ThirdPartyAppHomePage]: https://markdownmonster.west-wind.com/
[ThirdPartyAppOfficialLogo]: https://raw.githubusercontent.com/RickStrahl/MarkdownMonster/master/Art/MarkdownMonster.png
[VersionNumberBadgeURL]: https://vsmarketplacebadge.apphb.com/version/GregTrevellick.OpenInMarkdownMonster.svg
[VSMarketplaceUrl]: https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpenInMarkdownMonster
[VSMarketplaceReviewsUrl]: https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpenInMarkdownMonster#review-details

# Open In Markdown Monster

[![Licence](https://img.shields.io/github/license/gittools/gitlink.svg)](/LICENSE.txt)
[![Build status][AppVeyorProjectBuildStatusBadgeSvg]][AppVeyorProjectUrl]
[][VersionNumberBadgeURL]

Download this extension from the [VS Marketplace][VSMarketplaceUrl].

---------------------------------------

<!--COPY START FOR VS GALLERY-->

A [Visual Studio][https://www.visualstudio.com/] extension to open a file in [Markdown Monster][ThirdPartyAppHomePage] directly from within Visual Studio.

[![][ThirdPartyAppOfficialLogo]][ThirdPartyAppHomePage]

If you like this *free* extension, please give it a [review][VSMarketplaceReviewsUrl].

See the [change log](CHANGELOG.md) for road map and release history. Bugs can be logged [here][GitHubRepoIssuesURL].

## Features

![](OpenInApp/Resources/ReadMeScreenShot_ContextMenu.png)

- Open multiple files simultaneously with [Markdown Monster][ThirdPartyAppHomePage] directly from within Solution Explorer.

- Warning if attemptimg to open a large quantity of files. The quantity is configurable, and if set very high effectively suppresses the warning altogether.

- Warning if attempting to open one or more file types whose extension is not typically associated with Markdown Monster. The list of typical file extensions is configurable in Tools | Options, and the warning message can be suppressed.

## Options

![](OpenInApp/Resources/ReadMeScreenShot_OptionsGeneral.png)

<!--COPY END FOR VS GALLERY-->

## Contribute

Contributions to this project are welcome by raising an [Issue][GitHubRepoIssuesURL] or submitting a [Pull Request][GitHubRepoPullRequestsURL].

## License

[MIT](/LICENSE.txt)

## Legal

The [owner](https://github.com/GregTrevellick) of this [GitHub repository / software][GitHubRepoURL] is not affiliated, associated, authorized, endorsed by, employed by, sponsored by, or in any way officially connected with [Markdown Monster][ThirdPartyAppHomePage] or any of its subsidiaries or its affiliates.

Nor has [this][GitHubRepoURL] software been authorised, approved, verified or in anyway assessed by [Markdown Monster][ThirdPartyAppHomePage], or any of its subsidiaries or its affiliates, either as [raw source code][GitHubRepoURL] on [GitHub.com](https://github.com/) or as a [Visual Studio Extension][VSMarketplaceUrl] in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs).

All Trademark, intellectual property rights, and other rights belonging to [Markdown Monster][ThirdPartyAppHomePage] as described in [here][ThirdPartyAppHomePage] and [here][ThirdPartyAppHomePage] apply.

All Markdown Monster logos and Markdown Monster links belong to [Markdown Monster][ThirdPartyAppHomePage] and their use here and any associated goodwill inures to [Markdown Monster][ThirdPartyAppHomePage] as described [here][ThirdPartyAppHomePage].

In no event shall [Markdown Monster][ThirdPartyAppHomePage] be liable for any claim, damages or other liability, whether in an action of contract, tort or otherwise, arising from, out of or in connection with the software or the use or dealings in the software.

## Credits

Adapted from code originally written by [Mads Kristensen](https://github.com/madskristensen) [here](https://github.com/madskristensen/OpenInSublimeText/ "Open in Sublime Text") and [here](https://github.com/madskristensen/OpenInVsCode "Open in Visual Studio Code").

Also adapted from code originally written by [Calvin Allen](https://github.com/CalvinAllen) [here](https://github.com/CalvinAllen/OpenInNotepadPlusPlus).

Additional thanks goes to [Build 2016 Conference](https://channel9.msdn.com/Events/Build/2016/B886) and [Visual Studio Toolbox](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Extensions-by-Mads-Kristensen).

Thanks also to [Markdown Monster][ThirdPartyAppHomePage] themselves.
