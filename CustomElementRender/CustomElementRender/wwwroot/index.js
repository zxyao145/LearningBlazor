
window.highlight = (code, language) => {
    console.log(language, code);
    return Prism.highlight(code, Prism.languages[language], language);
}