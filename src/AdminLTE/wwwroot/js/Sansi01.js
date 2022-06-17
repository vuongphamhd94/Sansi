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



// them san pham
let bt = document.querySelector("#btmSubmit");
let sanPham = [];
if (bt) {
    bt.addEventListener("click", function () {

       

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


// phan trang, tim kiếm
const evtPr = () => {
    let pr = document.querySelector("#pr");
    pr.addEventListener("click", function () {
        let pg = document.querySelector(".trang>.current");
        let p = Number(pg.textContent);
        let searchName = $("#name").val();
        p--;
        show(5, p, searchName);

        console.log(searchName);
    })
}

const evtNx = () => {
    let nx = document.querySelector("#nx");
    nx.addEventListener("click", function () {
        let pg = document.querySelector(".trang>.current");
        let p = Number(pg.textContent);
        let searchName = $("#name").val();
        p++;
        show(5, p,searchName);

        console.log(searchName);
    })
}

evtNx();


//search
const evtSeach = () => {
    let search = $("#btmSearch");
    search.on("click", function () {
        let p = 1;
        let searchName = $("#name").val();
        show(5, p, searchName);

        console.log(searchName);
    })
}
let search = $("#btmSearch");
search.on("click", function () {
    let p = 1;
    let searchName = $("#name").val();
    show(5, p, searchName);

    console.log(searchName);
})


function show(n, p,searchName) {
    //debugger
    $.ajax({
        url: "/SansiHome/IndexPhanTrang",
        type: "POST",
        data: {
            n: n,
            p: p,
            searchName: searchName,
        }
    }).done(function (rs) {
        //debugger
        document.querySelector("#PhanTrang").innerHTML = rs;
        evtPr();
        evtNx();
        /*alert(rs);*/
    });

}