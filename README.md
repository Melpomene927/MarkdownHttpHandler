# MarkdownHttpHandler
�W�[IIS���x�w��Markdown���ɤ䴩��

# Installation
�sĶ�M�׫�Ndll�ޥΡA�üW�[web.config�Ѽƭ�

Edit `web.config` with:
```xml
<configuration>
    <system.webServer>
        <handlers>
            <add name="MdHandler" path="*.markdown|.*mdown|*.mkdn|*.mkd|.*md" verb="*" type="System.Web.Handlers.MarkdownHandler" resourceType="Unspecified" requireAccess="Read" preCondition="integratedMode" />
        </handlers>
    </system.webServer>
</configuration>
```

Any `.md` file is now converted to html and rendered. 

## Multiple file extensiosn

You can add additional `<add>` lines to handle other markdown file extensions. For example the following will remder `.md` and `.markdown` files:
```xml
<configuration>
    <system.webServer>
        <handlers>
            <add name="MdHandler" path="*.md" verb="*" type="System.Web.Handlers.MarkdownHandler" resourceType="Unspecified" requireAccess="Read" preCondition="integratedMode" />
            <add name="MarkdownHandler" path="*.markdown" verb="*" type="System.Web.Handlers.MarkdownHandler" resourceType="Unspecified" requireAccess="Read" preCondition="integratedMode" />
        </handlers>
    </system.webServer>
</configuration>
```
Note: Contrary to IIS 6.0, IIS 7.0 does not support multiple extensiosn in the same handler with `path="*.ma, *.markdown"`

Any `.md` or `.markdown` file is now converted to html and rendered. 

# Implementation detail
�ϥ� Strapdown.js �Nmarkdown�ରhtml�e�{

# Credits
http://strapdownjs.com/
https://github.com/orecht/MarkdownHttpHandler
