const api_url = "https://localhost:44310/api/All/getCatData";

var tags = [];

async function getapi(url) {
    const response = await fetch(url);
    var data = await response.json();
    console.log(data);
    tags = data;
    if (response) {
        hideloader();
    }
    show(data);
}

getapi(api_url);

function ac(value) {
    document.getElementById('datalist').innerHTML = '';
    l = value.length;
    var n = tags.length;
    for (var i = 0; i < n; i++) {
        if (((tags[i].toLowerCase()).indexOf(value.toLowerCase())) > -1) {
            var node = document.createElement("option");
            var val = document.createTextNode(tags[i]);
            node.appendChild(val);
            document.getElementById("datalist").appendChild(node);
        }
    }
}
w