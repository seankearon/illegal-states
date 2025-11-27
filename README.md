# Illegal States

Code for a lightning talk on making illegal states unrepresentable in C# and F#.

The code follows Scott Wlashin's excellent [Designing with types](https://fsharpforfunandprofit.com/posts/designing-with-types-intro/#series-toc) blog series.

There are tests for each language, but these don't assert that the code is correct, they just show the shape of the data in the console:

![img.png](img.png)

# How to follow

Start at the `main` branch, then follow the branches by number. 

## Main

This is the starting point.  It shows a naive implementation of a contact type and how that's not safe.