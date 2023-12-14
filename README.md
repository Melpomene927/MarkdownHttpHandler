# MarkdownHttpHandler
增加IIS站台針對Markdown文檔支援度

# Installation
編譯專案後將dll引用，並增加web.config參數值

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
使用 Strapdown.js 將markdown轉為html呈現

# Credits
http://strapdownjs.com/
https://github.com/orecht/MarkdownHttpHandler
