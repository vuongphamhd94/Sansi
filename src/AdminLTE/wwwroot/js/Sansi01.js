////const { Button } = require("bootstrap");

let tieuDe = document.querySelectorAll(".tim-kiem-sp-nav-top > div");
for (let i = 0; i < tieuDe.length; i++) {
    tieuDe[i].addEventListener("click", function () {
        if (i == 4) {
            return;
        }
        for (let j = 0; j < tieuDe.length; j++) {
            if (j == 4) {
               continue;
            }
            let ul = tieuDe[j].querySelector("ul");
            if (ul.classList != "hide") {
                ul.setAttribute("class", "hide");
            }

        }

        let ul = tieuDe[i].querySelector("ul");
        ul.removeAttribute("class")
        ul.addEventListener("click", function () {
            for (let j = 0; j < tieuDe.length; j++) {
                tieuDe[j].removeAttribute("class");
            }
            tieuDe[i].setAttribute("class", "selection");
        })
    })
}


let bt = document.querySelector("#bt-sm");
let sanPham = [];
bt.addEventListener("click", function () {

    // let newSanPham  = {
    //    name: document.querySelector("#name").value,
    //    title: document.querySelector("#image").value,
    //    price: document.querySelector("#price")
    //}
    //sanPham.push(newSanPham);
    //console.log(newSanPham);

    
    $.ajax({
        url: "/SansiHome/AddDanhMucSanPham",
        method: "POST",
        data: {
            /*Id: 2,*/
            TenSanPham: "San Pham 01",
            Type: 1,
            GiaSanPham: 12.5,
            UrlImage: "link o1"
        }
    }).done(function () {
        console.log("Hoan thanh")
    });
});

/*let url = "/cotrollerName/functionName";*/