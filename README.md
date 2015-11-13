##Summary
This tool allows easy rating enabling for lists using Client Object Model.
Works in On-Premise as well as in O365

## Parameters
ListName - The name of the list where the ratings should be enabled
RatingType - Rating Type on the list. Can be Likes or Ratings (Stars)
ClientContext - The client context of the target Web

## Prerequisites
Target web must be a publishing web

## How to use?
PS> Import-Module SPO.EnableRatings.dll
PS> Set-SPORating -ListName "Pages" -RatingType Ratings -Context $context

## Other info

The cmdlet has been adapted from the code of the O365 PnP Samples Repository. https://github.com/OfficeDev/PnP

## Licensing
This software is provided as-is.
The original creator's licence applies here as well (Apache License)
