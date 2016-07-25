#URL Fetcher

Brings a tiny content from a URL. Useful in API data pulls.


## Usage

```
using URLFetchers.Library;

URLFetcher uf = new URLFetcher();
string url = "http://www.example.com/lorem.php";
string text = uf.fetch(url);
```

## POST
```
using URLFetchers.Library;
using System.Collections.Specialized;

URLFetcher uf = new URLFetcher();
string request_url = "http://localhost/api/post.php";

NameValueCollection data = new NameValueCollection();
data["username"] = "username";
data["password"] = "password";

string response = uf.post(request_url, data);
```
