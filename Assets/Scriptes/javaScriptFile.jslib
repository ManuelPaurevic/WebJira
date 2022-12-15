mergeInto(LibraryManager.library, {

    jsAPICall:async function (token){
        const email = "manuel.paurevic@oasisdigital.com";
        const authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));
        const response = await fetch('https://oasisintern.atlassian.net/rest/api/latest/myself', {
            Method: 'GET',
            credentials: "include",
            headers: {
                Accept: 'application.json',
                'Content-Type': 'application/json',
                'Authorization': "Basic " + authCache,
                'Access-Control-Allow-Headers': '*',
            }
        })

        return response;
    },


});