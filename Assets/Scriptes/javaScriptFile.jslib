mergeInto(LibraryManager.library, {

    Hello: function () {
        window.alert("Hello, world!");
    },

    jsAPICall:async function (token){
        const email = "manuel.paurevic@oasisdigital.com";
        const authCache = "bWFudWVsLnBhdXJldmljQG9hc2lzZGlnaXRhbC5jb206eWlNZ1BnSzlQZ3d2Rnp5RUY3c2I0NzM4";
        let response = await fetch('https://oasisintern.atlassian.net/rest/api/latest/myself', {
            Method: 'GET',
            Mode: 'no-cors',
            credentials: "include",
            headers: {
                Accept: 'application.json',
                'Content-Type': 'application/json',
                'Authorization': "Basic " + authCache,
            }
        })

        return response.json();
    },


});