# Test Naming Kevlin Henney Style

This repository demonstrates the test naming suggested in the a talk at NDC 2014. A recorded version of the talk is available on <http://vimeo.com/97329157> the part about test naming starts at 58:48. 

On of the major points about test naming was also made be [Kevlin Henney](https://twitter.com/KevlinHenney) in the following tweet:

<blockquote class="twitter-tweet" lang="en"><p>Test names should reflect outcome not aspiration: doesn&#39;t make sense to see &quot;X should give Y&quot; as a result; on passing, result is &quot;X gives Y&quot;</p>&mdash; Kevlin Henney (@KevlinHenney) <a href="https://twitter.com/KevlinHenney/status/350242801868484608">June 27, 2013</a></blockquote>
<script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>

I wrote the example code in steps:

1. Write out specification of the `Categorizer` as test cases
2. Implement the test cases one by one - and refactor on green when appropriate.
3. Done.