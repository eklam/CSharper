#CSharper

### [Full doc here](https://github.com/eklam/CSharper/wiki)

###String usage

Much clearer

```csharp
string project = "CSharper";
var formatted = "Hello {0}!".F(project);
```

###IEnumerable

Will not throw exception!

```csharp
List<YourClass> lst = null;
lst.Safe().Where(x => x.Property >= 5);
```

###Random Usage

Much, much clearer

```csharp
Random r = new Random();
var oneOfThat = r.OneOf(1, 2, 3);
```

---

###Origin & Credits

I keep asking my self why some of syntax things in C# are they way they are... C# is a beautiful language, but it could be prettier, and Sharper!

So I got a bunch of the extensions methods I always re-implement, and put here together, I am also using the following works as inspiration:

[Old question on StackOverflow with tons of wonderfull extension methods](http://stackoverflow.com/questions/271398/what-are-your-favorite-extension-methods-for-c-codeplex-com-extensionoverflow)

[ExtensionOverflow] (https://extensionoverflow.codeplex.com/) - Deprecated codeplex project with some implementations]

[MiscUtil] (http://www.yoda.arachsys.com/csharp/miscutil/) - Deprecated lib with some really nice tricks:

[Cadenza] (http://gitorious.org/cadenza) - Another deprecated project:


[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/eklam/CSharper/trend.png)](https://bitdeli.com/free "Bitdeli Badge")

