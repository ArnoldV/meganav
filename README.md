# Umbraco Meganav

[![Build status](https://ci.appveyor.com/api/projects/status/xi37v81yqo7vhg4d/branch/master?svg=true)](https://ci.appveyor.com/project/Cogworks/meganav/branch/master)
[![NuGet release](https://img.shields.io/nuget/v/Cogworks.Meganav.svg)](https://www.nuget.org/packages/Cogworks.Meganav)
[![Our Umbraco project page](https://img.shields.io/badge/our-umbraco-orange.svg)](https://our.umbraco.org/projects/website-utilities/meganav/)

A flexible, draggable link picker for constructing site navigation menus, big or small, in Umbraco 7.

## Getting started

This package is supported on Umbraco 7.6.2+.

### Installation

Meganav is available from Our Umbraco, NuGet, or as a manual download directly from GitHub.

#### Our Umbraco repository
You can find a downloadable package, along with a discussion forum for this package, on the [Our Umbraco](https://our.umbraco.org/projects/website-utilities/meganav/) site.

#### NuGet package repository
To [install from NuGet](https://www.nuget.org/packages/Cogworks.Meganav/), run the following command in your instance of Visual Studio.

    PM> Install-Package Cogworks.Meganav

## Usage

After installing the package, you'll be able to create a new Data Type based on _Cogworks.Meganav_ via the Umbraco backoffice.

![Meganav Data Type](docs/img/prevalue-editor.jpg?raw=true)

Here you can configure the "Max depth" of the navigation - the maximum number of levels deep at which an editor can place nav items. You also have the option to prevent nav items where the _umbracoNaviHide_ property has been set from rendering on the front-end - these items will still appear in the backoffice but not on your website, you can still edit or change them as you wish. By default both of these settings are left unset.

Now your Data Type is ready, we need to add it to a Document Type. This is done in the usual way - you will find Meganav appears in the "pickers" section when selecting a property to add.

![Meganav Property Editor](docs/img/property-editor.jpg?raw=true)

Wow! That was easy! You now have a shiny new navigation picker setup for your content editors to enjoy.

In the backoffice, the design of Meganav closely follows the other pickers in Umbraco to ensure your editor's experience is as familiar as possible.

![Meganav](docs/img/nav-items.jpg?raw=true)

Click and drag an item to change it's position within the navigation; drop it wherever you choose. Unpublished items will appear faded out and will not show on the front-end of the website. If you have the "Remove NaviHide Items" setting enabled, any items where the _umbracoNaviHide_ property has been set on the selected content node will appear with a red outline in the backoffice and will also not show on the front-end.

![Meganav Edit Item](docs/img/edit-nav-item.jpg?raw=true)

When editing a navigation item you have the flexibility to modify how the link behaves on the front-end. Entering text into the "Link Title" field will display in place of the select content's name. Changing the "Target" property alters how the link opens when clicked; either in the current window, a new tab, or a new browser window.

### Integration

Meganav was designed to be as clean and simple for developers as it is for content editors.

Check out the [integration guide](docs/integration-guide.md) to learn how to embed the package in your site.

### Contribution guidelines

To raise a new bug, create an issue on the GitHub repository. To fix a bug or add new features, fork the repository and send a pull request with your changes. Feel free to add ideas to the repository's issues list if you would to discuss anything related to the package.

### Who do I talk to?
This project is maintained by [Cogworks](https://thecogworks.com/) and contributors. If you have any questions about the project please contact us through the forum on Our Umbraco, on [Twitter](https://twitter.com/cogworks), or by raising an issue on GitHub.

## Coming soon

* Umbraco Cloud / Courier support
* Collapsable tree sections
* Multi-lingual support
* More...!

## Credits

Meganav uses a _slightly_ modified version of [Angular UI Tree](https://github.com/angular-ui-tree/angular-ui-tree) v2.11.0 (MIT license)

### A special #h5yr to our contributors

* [Marcin Zajkowski](https://twitter.com/zajkowskimarcin)
* [Arnold Visser](https://twitter.com/aim24)
* [Robin Neal](https://twitter.com/SudoCat429)
* [Lee Kelleher](https://twitter.com/leekelleher)
* [kows] (https://github.com/kows)

## License

Copyright &copy; 2017 [The Cogworks Ltd](http://www.thecogworks.com/), and other contributors

Licensed under the MIT License.