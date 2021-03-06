window.browserInterop = {
    showPrompt: function (message) {
        return prompt(message, 'Type anything here');
    },
    getDocumentTitle: function () {
        return document.title;
    },
    setDocumentTitle: function (value) {
        document.title = value;
    },
    scrollToTop: function () {
        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
    },
    navigate: function (href, newTab) {
        if (newTab === void 0) { newTab = false; }
        Object.assign(document.createElement('a'), {
            target: (newTab ? '_blank' : '_self'),
            href: href
        }).click();
    }
};
//# sourceMappingURL=browserInterop.js.map