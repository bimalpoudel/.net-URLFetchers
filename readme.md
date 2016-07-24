#URL Fetcher

Brings a tiny content from a URL. Useful in API data pulls.


## Usage

```
using URLFetchers.Library;

URLFetcher uf = new URLFetcher();
string url = "http://www.example.com/lorem.php";
string text = uf.fetch(url);
```
