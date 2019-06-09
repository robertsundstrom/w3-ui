// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

interface Window 
{
  browserInterop: {
    showPrompt(message: string): void;
    getDocumentTitle(): string;
    setDocumentTitle(value: string): void;
    scrollToTop(): void;
    navigate(href: string, newTab?: boolean): void;
  }
}

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
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
  },
  navigate: function (href, newTab = false) {
    Object.assign(document.createElement('a'), {
        target: (newTab ? '_blank' : '_self'),
        href,
    }).click();
  }
};

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
      document.getElementById("scrollTopButton").style.display = "block";
  } else {
      document.getElementById("scrollTopButton").style.display = "none";
  }
}