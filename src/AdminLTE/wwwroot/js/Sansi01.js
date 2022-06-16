////const { Button } = require("bootstrap");

//const apply = require("core-js/library/fn/reflect/apply");


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




let bt = document.querySelector("#btmSubmit");
let sanPham = [];
if (bt) {
    bt.addEventListener("click", function () {

        //let newSanPham = {
        //    name: document.querySelector("#name").value,
        //    title: document.querySelector("#image").value,
        //    price: document.querySelector("#price")
        //}
        //sanPham.push(newSanPham);
        //console.log(newSanPham);

        var data = {
            TenSanPham: $("#name").val(),
            Type: $("#title").val(),
            GiaSanPham: $("#price").val(),
            UrlImage: $("#image").val()
        }

        $("#name").val("") ;
        $("#title").val("");
        $("#price").val("");
        $("#image").val("");

        $.ajax({
            url: "/SansiHome/AddDanhMucSanPham",
             method: "POST",
            data: data,
        }).done(function (rs) {
            alert(rs);
        });
    });
}



const evtPr = () => {
    let pr = document.querySelector("#pr");
    pr.addEventListener("click", function () {
        let pg = document.querySelector(".trang>.current");
        let p = Number(pg.textContent);
        p--;
        show(5, p);
    })
}

const evtNx = () => {
    let nx = document.querySelector("#nx");
    nx.addEventListener("click", function () {
        let pg = document.querySelector(".trang>.current");
        let p = Number(pg.textContent);
        p++;
        show(5, p);
    })
}

evtNx();


function show(n, p) {
    //debugger
    $.ajax({
        url: "/SansiHome/IndexPhanTrang",
        type: "POST",
        data: {
            n: n,
            p: p
        }
    }).done(function (rs) {
        //debugger
        document.querySelector("#PhanTrang").innerHTML = rs;
        evtPr();
        evtNx();
        /*alert(rs);*/
    });

}