@import url("https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;500;600;700;800&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap");
:root {
  --header-height: 3rem;
  --nav-width: 132px;
  --first-color: black;
  --first-color-light: grey;
  --white-color: #f7f6fb;
  --body-font: "Nunito", sans-serif;
  --normal-font-size: 1rem;
  --z-fixed: 100;
}

*,
::before,
::after {
  box-sizing: border-box;
}

body {
  position: relative;
  margin: var(--header-height) 0 0 0;
  font-family: var(--body-font);
  font-size: var(--normal-font-size);
  transition: 0.5s;
  background-color: rgb(20, 20, 20) !important;
}

a {
  text-decoration: none;
}

.navlist_twoclass {
  display: none;
}

.searchcontainer {
  width: 100%;
  display: flex;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.searchcontainer .searchicon {
  position: relative;
  left: 40px;
}

.searchcontainer .icon {
  background-color: rgb(96, 94, 0);
  backdrop-filter: blur(1px);
  opacity: 0.6;
  padding: 5px 10px 10px 10px;
  border-radius: 8px;
}

.searchcontainer .searchinputfield {
  background: #262626;
  border-radius: 8px;
  border: none;
  outline: none;
  color: white;
  width: 100%;
  height: 40px;
  padding-left: 60px;
}

.searchcontainer .secondcontainer {
  width: 260px;
  margin-left: 20px;
  height: 60px;
  margin-top: 2px;
  margin-right: 10px;
  align-items: center;
  position: relative;
  padding-left: 20px;
  border: 1px solid rgb(93, 93, 93);
  border-radius: 20px;
  cursor: pointer;
  display: flex;
}

.searchcontainer .bellIcon {
  margin-left: 12px;
}

.searchcontainer .dropdown-toggle::after {
  content: none !important;
}
.searchcontainer .dropdown_submenu {
  width: 300px;
  background: #242323;
  border-radius: 16px;
  margin-top: 10px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo {
  width: 260px;
  cursor: pointer;
  margin-left: 20px;
  height: 60px;
  margin-top: 2px;
  align-items: center;
  position: relative;
  border: none;
  border-radius: 20px;
  display: flex;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd {
  position: absolute;
  right: 10px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass {
  position: absolute;
  top: 5px;
  left: 50px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass .userprofileheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass .verifiedheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #ffffff;
  opacity: 0.4;
}
.searchcontainer .dropdown_submenu .addprofile {
  display: flex;
  width: 300px;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  padding-top: 20px;
}
.searchcontainer .dropdown_submenu .addprofile .addprofiletext {
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #bdbbbb;
}

.searchcontainer .secondcontainer .dropd {
  position: absolute;
  right: 20px;
}

.searchcontainer .secondcontainer .lineclass {
  position: absolute;
  top: 5px;
  left: 70px;
}

.searchcontainer .secondcontainer .lineclass .userprofileheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}

.searchcontainer .secondcontainer .lineclass .verifiedheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #ffffff;
  opacity: 0.4;
}

.row .search {
  width: 100%;
  height: 60px;
  background: black;
  border-radius: 14px;
  padding-left: 80px;
}

.row .searchIcon {
  position: absolute;
  left: 14.92%;
  right: 91.38%;
  top: 31.81%;
  bottom: 32.93%;
  color: #c4c4c4;
}

.row .imageDropDown {
  width: 260px;
  border: 1.5px solid #ffffff;
  border-radius: 16px;
  height: 60px;
}

.row .avatar {
  margin-top: 8px;
}

.row ::placeholder {
  color: #c4c4c4;
  text-align: left;
}

.line {
  width: 100%;
  left: 376px;
  top: 147px;
  opacity: 0.1;
  border: 1px solid #ffffff;
}

.navlist_twoclass {
  display: none;
}

.header {
  width: 100%;
  height: var(--header-height);
  position: fixed;
  top: 0;
  left: 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0rem 1rem;
  background-color: var(--white-color);
  z-index: var(--z-fixed);
  transition: 0.5s;
  background-color: #141414;
}

.header .openMobileMono {
  display: none;
}

.header_toggle {
  color: white;
  font-size: 1.5rem;
  cursor: pointer;
  background-color: rgb(81, 80, 80);
  position: relative;
  left: 0;
  padding: 10px 6px 10px 6px;
  margin-left: 20px;
  border-radius: 0px 10px 10px 0px;
}

.header_img {
  width: 35px;
  height: 35px;
  display: flex;
  justify-content: center;
  border-radius: 50%;
  overflow: hidden;
}

.header_img img {
  width: 40px;
}

.l-navbar {
  position: fixed;
  top: 0;
  left: -30%;
  width: 90px;
  height: 100%;
  background-color: #141414;
  padding: 0.5rem 1rem 0 0;
  transition: 0.5s;
  z-index: var(--z-fixed);
}

.nav {
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  overflow: hidden;
  padding-left: 30px !important;
}

.navbar-toggler:focus {
  text-decoration: none;
  outline: 0;
  box-shadow: none !important;
}

.nav-tabs {
  border-bottom: none !important;
}

.navitemclass {
  padding-bottom: 12px;
  width: 50% !important;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: center;
}

.navitemclass:focus {
  border-bottom: 2px solid white !important;
}

.accordion-button:focus {
  z-index: 3;
  border-color: transparent !important;
  outline: 0;
  box-shadow: none !important;
}

.accordion-item:first-of-type .accordion-button {
  border-top-left-radius: 0.25rem;
  border-top-right-radius: 0.25rem;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 16px;
  margin-left: -26.5px;
  background-color: transparent !important;
  line-height: 22px;
  align-items: center;
}
.accordion-item:first-of-type .accorbd {
  background-color: #141414;
}
.accordion-item:first-of-type .accorbd .inneraccor {
  margin-left: 7px;
}
.accordion-item:first-of-type .accorbd .inneraccor span {
  font-size: 14px;
  margin-left: -20px;
}
.accordion-item:first-of-type .accorbtn {
  background-color: #141414 !important;
  border: none;
  outline: none;
  width: 280px;
  color: #ffffff;
}
.accordion-item:first-of-type .accorbtn .nav_nameTwo {
  margin-left: 40px;
}
.accordion-item:first-of-type .accorbtn:hover {
  background: radial-gradient(354.23% 3112.34% at -29.41% 333.8%, rgba(255, 187, 84, 0.2) 50.63%, rgba(255, 187, 84, 0) 100%) !important;
  color: #ffbb54 !important;
}
.accordion-item:first-of-type .accordion-button::after {
  content: "";
  background-image: url(../../img/vectorarrow.png) !important;
  margin-left: 16px;
  background-size: 11.3px;
  margin-top: -12px;
  transform: rotate(180deg);
}

.nav_list .navlinkthree {
  position: relative;
  top: 8px;
  left: px;
}
.nav_list .nav_link {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 16px;
  line-height: 27px;
  color: #ffffff;
}

.nav_logo,
.nav_link {
  cursor: pointer;
  display: grid;
  grid-template-columns: max-content max-content;
  align-items: center;
  align-items: center;
  column-gap: 2.4rem;
  padding: 0.5rem 0rem 0.5rem 1.5rem;
}

.nav_link:hover {
  background: radial-gradient(354.23% 3112.34% at -29.41% 333.8%, rgba(255, 187, 84, 0.2) 50.63%, rgba(255, 187, 84, 0) 100%) !important;
  color: #ffbb54 !important;
  width: 100% !important;
  height: 100% !important;
}

.nav_logo {
  margin-bottom: 2rem;
  margin-top: -10px;
  font-family: "Poppins";
  font-style: normal;
  font-size: 36px;
  line-height: 54px;
  margin-left: -45px;
  color: #ffffff;
}

.nav_logo-icon {
  font-size: 1.25rem;
  color: var(--white-color);
}

.nav_logo-name {
  color: var(--white-color);
  font-weight: 800;
  letter-spacing: 5px;
  margin-left: 13px;
}

.nav_link {
  position: relative;
  color: var(--first-color-light);
  margin-bottom: 1rem;
  left: 0;
  margin-left: -30px;
  transition: 0.3s;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
}

.nav_icon {
  font-size: 1.25rem;
}

.show {
  left: 0;
}

.active {
  color: var(--white-color);
}

.active::before {
  content: "";
  position: absolute;
  left: 0;
  top: 0px;
  width: 2px;
  height: 45px;
  background-color: #ffbb54;
}

.height-100 {
  height: 100vh;
}

.mainCard {
  margin-left: 30px;
  margin-top: 20px;
  background-color: #0e0e0e;
  border-radius: 28px;
}

.mainCard .videoclass {
  width: 320px;
}

.videoheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 38px;
  line-height: 57px;
  color: #ffffff;
}

.secondarytext {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 30px;
  color: #ffffff;
  opacity: 0.6;
}

.secondaryheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 17px;
  line-height: 28px;
  color: #ffffff;
}

.thirdheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
  opacity: 0.6;
}

.headingcontainer {
  width: 200px;
}

.maincard .videoclass {
  width: 320px;
}

.maincard .submaincontainer {
  padding: 0px 32px;
}

.datadiv {
  background-color: #0e0e0e !important;
  padding: 30px;
}

.videodiv {
  width: 332px;
  left: 419px;
  background: url(image.png);
  border-radius: 14px;
}

.topdiv {
  position: relative;
  top: 0px;
  padding-left: 170px;
}

.topdiv .headmain .videolesson {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 38px;
  line-height: 57px;
  color: #ffffff;
}

.topdiv .headmain .parahead {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 30px;
  color: #ffffff;
  opacity: 0.6;
}

.firstcontainer {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  margin-left: 150px !important;
}

.firstcontainer .mainContainer {
  margin-top: 0px;
  width: 100%;
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
}

.firstcontainer .mainContainer .secondmaincontainer {
  padding: 40px;
  height: 335px;
  border-radius: 30px;
  width: 100%;
  margin-left: 15px;
  margin-right: 10px;
  position: relative;
  background: #0e0e0e;
}

.firstcontainer .mainContainer .secondmaincontainer .containerimage1 {
  position: absolute;
  left: 40%;
  top: 0;
}

.firstcontainer .mainContainer .secondmaincontainer .containerimage2 {
  position: absolute;
  right: 0;
  bottom: 0;
}

.firstcontainer .mainContainer .secondmaincontainer .thirdcontainer {
  width: 100%;
  display: flex;
  justify-content: space-between;
  align-items: flex-end;
}

.firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer {
  display: flex;
  margin-top: 10px;
}

.firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .thirdsubsubcontainer {
  background: #323232;
  border-radius: 14px;
  padding: 10px 20px;
  display: flex;
  align-items: center;
  flex-direction: column;
}

.firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .transactions {
  margin-left: 14px;
}

.firstcontainer .mainContainer .secondmaincontainer .paratext {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}

.firstcontainer .mainContainer .secondmaincontainer .paratexttwo {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  margin-bottom: 5px;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
  opacity: 0.55;
}

.firstcontainer .mainContainer .secondmaincontainer .headertext {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 24px;
  line-height: 36px;
  color: #ffffff;
}

.firstcontainer .mainContainer .secondmaincontainer .parayellowtext {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 50px;
  line-height: 75px;
  color: #ffbb54;
}

.firstcontainer .twocontainer {
  background: #0e0e0e;
  border-radius: 18px;
  width: 70%;
  height: 335px;
  padding: 40px 40px;
  margin-left: 20px;
  margin-right: 30px;
}

.firstcontainer .twocontainer .twosubcontainer {
  display: flex;
  justify-content: space-between;
}

.firstcontainer .twocontainer .twosubcontainer .paratexttwo {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
  opacity: 0.55;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer {
  width: 90px;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer .dropdownbutton {
  background: #0e0e0e;
  border: 1.5px solid #494949;
  border-radius: 10px;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer {
  width: 20%;
  position: relative;
  left: -200px;
  background: #161616;
  border-radius: 12px;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer {
  display: flex;
  align-items: center;
  justify-content: space-evenly;
  border-bottom: 1px solid black;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer {
  display: flex;
  flex-direction: column;
  margin-top: 10px;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .btcheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}

.firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .numberheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 12px;
  line-height: 16px;
  /* identical to box height, or 133% */
  display: flex;
  align-items: center;
  color: #aeb6ce;
}

.firstcontainer .twosubcontainervalue {
  display: flex;
  align-items: center;
}

.firstcontainer .twosubcontainervalue .greenrating {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 10px;
  line-height: 15px;
  margin-left: 20px;
  margin-top: 10px;
  color: #3ed10a;
}

.firstcontainer .twosubcontainervalue .headertext {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 20px;
  line-height: 30px;
  color: #ffffff;
}

.firstcontainer .canvasfirstcontainer {
  width: 100%;
  height: 215px;
  padding: 10px;
}

.firstcontainer .canvasfirstcontainer .subcanvascontainer {
  width: 100% !important;
  height: 120px !important;
}

.firstcontainer .assetsmainsection {
  display: flex;
  align-items: center;
  justify-content: center;
}

.firstcontainer .assetsmainsection .assetmaincontainer {
  width: 100%;
  margin-top: 30px;
  padding-left: 20px;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 16px;
  line-height: 24px;
  color: #ffffff;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer {
  display: flex;
  padding: 10px 30px 10px 30px;
  justify-content: space-evenly;
  background: #0e0e0e;
  border-radius: 18px;
  margin-left: -5px;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer {
  display: flex;
  margin-left: 70px;
  flex-direction: column;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .canvasgraphcontainer {
  width: 100%;
  margin-left: 30px;
  margin-right: 30px;
}

.canvasgraphcontainer .canvasgraph {
  width: 100%;
  height: 120px;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .bitcoinheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 24px;
  line-height: 36px;
  color: #ffffff;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .BTCheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
  opacity: 0.8;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .sellheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 21px;
  color: #14bd6c;
  margin-left: 10px;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .firstnumberheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 20px;
  line-height: 30px;
  color: #ffffff;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer {
  align-items: center;
  display: flex;
  flex-direction: column;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .seconddateheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 12px;
  line-height: 18px;
  text-align: right;
  color: #ffffff;
  position: relative;
  top: 10px;
  opacity: 0.6;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .coinbaseheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 10px;
  line-height: 15px;
  color: #ffffff;
  position: relative;
  top: 12px;
  opacity: 0.4;
}

.firstcontainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .lastdateheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 18px;
  line-height: 27px;
  color: #14bd6c;
}

.firstcontainer .assetsmainsection .tabscontainer {
  margin-left: 30px;
  margin-right: 30px;
  height: auto;
  width: 66%;
  margin-top: 30px;
  background: #0e0e0e;
  border-radius: 18px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabsmaincontainer {
  display: flex;
  align-items: center;
  justify-content: space-around;
  padding: 20px 0px 0px 0px;
  padding-bottom: 16px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabsmaincontainer .navitemclass {
  text-decoration: none;
  list-style-type: none;
  list-style: none;
  width: auto;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 18px;
  line-height: 27px;
  color: #ffffff;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer {
  display: flex;
  align-items: center;
  flex-direction: column;
  padding: 20px 7px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond {
  border-radius: 14px;
  background: #272727;
  margin-top: 10px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond {
  display: flex;
  width: 100%;
  background: #272727;
  border-radius: 14px;
  align-items: center;
  justify-content: space-between;
  padding: 10px 20px 16px 10px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .coinnameheading {
  font-family: "Poppins";
  font-style: normal;
  margin-left: 10px;
  font-weight: 500;
  font-size: 10px;
  line-height: 15px;
  position: relative;
  top: 5px;
  color: #ffffff;
  opacity: 0.6;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub {
  display: flex;
  align-items: center;
  padding: 0px 10px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub .bitcoinheading {
  margin-left: 10px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  margin-top: 5px;
  font-size: 16px;
  line-height: 24px;
  color: #ffffff;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst {
  display: flex;
  width: 100%;
  background: #272727;
  border-radius: 14px;
  align-items: center;
  justify-content: space-between;
  padding: 10px 20px 16px 10px;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .coinnameheading {
  font-family: "Poppins";
  font-style: normal;
  margin-left: 10px;
  font-weight: 500;
  font-size: 10px;
  line-height: 15px;
  color: #ffffff;
  position: relative;
  top: 5px;
  left: 2px;
  opacity: 0.6;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub {
  display: flex;
  margin-left: 10px;
  align-items: center;
  width: 100%;
}

.firstcontainer .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub .bitcoinheading {
  margin-left: 10px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  margin-top: 5px;
  font-size: 16px;
  line-height: 24px;
  color: #ffffff;
}

@media screen and (min-width: 768px) {
  body {
    margin: calc(var(--header-height) + 1rem) 0 0 0;
    /* padding-left: calc(var(--nav-width) + 2rem) */
  }

  .header {
    height: calc(var(--header-height) + 1rem);
    padding: 0 2rem 0 calc(var(--nav-width) + 2rem);
  }

  .header_img {
    width: 40px;
    height: 40px;
  }

  .header_img img {
    width: 45px;
  }

  .l-navbar {
    left: 0;
    padding: 1rem 1rem 0 0;
  }

  .show {
    width: calc(var(--nav-width) + 150px);
  }

  .body-pd {
    /* padding-left: calc(var(--nav-width) + 188px) */
  }
}
@media screen and (max-width: 767px) {
  .body-pd {
    /* padding-left: calc(var(--nav-width) + 188px) */
    padding-left: 0px;
  }
}
.test {
  padding-left: -100px;
  z-index: 1;
}

.checkToggle {
  margin-left: 190px;
  border-radius: 10px 0px 0px 10px;
  transform: rotate(180deg);
}

@media screen and (max-width: 991px) {
  .avatar {
    margin-left: 20px;
  }

  .navlist_twoclass {
    display: block !important;
    padding-left: 80px;
    padding-top: 40px;
  }

  .header {
    padding: 40px 20px;
  }

  .header .openMobileMono {
    display: block !important;
    position: absolute;
    right: 20px;
  }

  .header_toggle {
    display: none;
  }

  .l-navbar {
    display: none !important;
  }

  .l-navbar .nav {
    display: none !important;
  }

  .searchcontainer .bellIcon {
    display: none;
  }

  .searchcontainer .searchicon {
    display: none;
  }

  .searchcontainer .searchinputfield {
    display: none;
  }

  .searchcontainer .icon {
    display: none;
  }

  .searchcontainer .secondcontainer {
    width: 220px !important;
    margin-left: 0px !important;
    height: 42px !important;
    padding-left: 10px !important;
    display: none !important;
    border: none !important;
    border-radius: 0px !important;
  }

  .searchcontainer .secondcontainer .dropd {
    display: none !important;
    position: absolute;
    right: 10px !important;
  }

  .searchcontainer .secondcontainer .lineclass {
    position: absolute;
    top: 2px !important;
    left: 70px;
  }

  .searchcontainer .secondcontainer .lineclass .userprofileheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }

  .searchcontainer .secondcontainer .lineclass .verifiedheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 11px;
    line-height: 16px;
    position: absolute;
    bottom: -23px;
    color: #ffffff;
    opacity: 0.4;
  }

  .topdiv {
    padding-left: 10px;
  }

  .topdiv .headmain .videolesson {
    font-size: 26px;
  }

  .topdiv .headmain .parahead {
    margin-top: -18px;
  }

  .firstcontainer {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    margin-left: 0 !important;
  }

  .firstcontainer .mainContainer {
    margin-top: 0px;
    flex-direction: column;
  }

  .firstcontainer .mainContainer .secondmaincontainer {
    padding: 40px;
    border-radius: 30px;
    width: 100%;
    position: relative;
    background: #0e0e0e;
  }

  .firstcontainer .mainContainer .secondmaincontainer .containerimage1 {
    position: absolute;
    left: 40%;
    top: 0;
  }

  .firstcontainer .mainContainer .secondmaincontainer .containerimage2 {
    position: absolute;
    right: 0;
    bottom: 0;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer {
    width: 100%;
    display: flex;
    justify-content: space-between;
    align-items: flex-end;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer {
    display: flex;
    margin-top: 10px;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .thirdsubsubcontainer {
    background: #323232;
    border-radius: 14px;
    padding: 10px 20px;
    display: flex;
    align-items: center;
    flex-direction: column;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .transactions {
    margin-left: 14px;
  }

  .firstcontainer .mainContainer .secondmaincontainer .paratext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .secondmaincontainer .paratexttwo {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    margin-bottom: 5px;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.55;
  }

  .firstcontainer .mainContainer .secondmaincontainer .headertext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 24px;
    line-height: 36px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .secondmaincontainer .parayellowtext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 50px;
    line-height: 75px;
    color: #ffbb54;
  }

  .firstcontainer .twocontainer {
    background: #0e0e0e;
    border-radius: 18px;
    width: 100%;
    height: auto;
    margin-top: 30px;
    margin-left: 0px;
    margin-right: 0px;
  }

  .firstcontainer .twocontainer .twosubcontainer {
    display: flex;
    justify-content: space-between;
    padding: 20px 20px;
  }

  .firstcontainer .twocontainer .twosubcontainer .paratexttwo {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.55;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer {
    width: 90px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer .dropdownbutton {
    background: #0e0e0e;
    border-radius: 18px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer {
    width: 20%;
    position: relative;
    left: -200px;
    background: #161616;
    border-radius: 12px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer {
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    border-bottom: 1px solid black;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer {
    display: flex;
    flex-direction: column;
    margin-top: 10px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .btcheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .numberheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 12px;
    line-height: 16px;
    /* identical to box height, or 133% */
    display: flex;
    align-items: center;
    color: #aeb6ce;
  }

  .firstcontainer .twosubcontainervalue {
    margin-left: 20px;
    display: flex;
    align-items: center;
  }

  .firstcontainer .twosubcontainervalue .greenrating {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 10px;
    line-height: 15px;
    margin-left: 20px;
    margin-top: 10px;
    color: #3ed10a;
  }

  .firstcontainer .twosubcontainervalue .headertext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 20px;
    line-height: 30px;
    color: #ffffff;
  }

  .assetsmainsection {
    width: 100%;
    flex-direction: column;
  }

  .assetsmainsection .assetmaincontainer {
    width: 100%;
    margin-top: 30px;
    padding-left: 20px;
  }

  .assetsmainsection .assetmaincontainer .assetsheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer {
    display: flex;
    padding: 10px 30px 10px 30px;
    justify-content: space-evenly;
    background: #0e0e0e;
    border-radius: 18px;
    margin-left: -5px;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer {
    display: flex;
    margin-left: 70px;
    flex-direction: column;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .canvasgraphcontainer {
    width: 100%;
    margin-left: 30px;
    margin-right: 30px;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .bitcoinheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 24px;
    line-height: 36px;
    color: #ffffff;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .BTCheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.8;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .sellheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #14bd6c;
    margin-left: 10px;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .firstnumberheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 20px;
    line-height: 30px;
    color: #ffffff;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer {
    align-items: center;
    display: flex;
    flex-direction: column;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .seconddateheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 12px;
    line-height: 18px;
    text-align: right;
    color: #ffffff;
    position: relative;
    top: 10px;
    opacity: 0.6;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .coinbaseheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    position: relative;
    top: 12px;
    opacity: 0.4;
  }

  .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .lastdateheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 27px;
    color: #14bd6c;
  }

  .assetsmainsection .tabscontainer {
    margin-left: 0px;
    margin-right: 0px;
    width: 100% !important;
    margin-top: 20px !important;
  }

  .assetsmainsection .tabscontainer .tabsmaincontainer {
    display: flex;
    align-items: center;
    justify-content: space-around;
    padding: 20px 0px 0px 0px;
    width: 100%;
    padding-bottom: 16px;
  }

  .assetsmainsection .tabscontainer .tabsmaincontainer .navitemclass {
    text-decoration: none;
    list-style-type: none;
    list-style: none;
    width: auto;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 27px;
    color: #ffffff;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer {
    display: flex;
    align-items: center;
    width: 100%;
    flex-direction: column;
    padding: 20px 7px;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond {
    border-radius: 14px;
    background: #272727;
    margin-top: 10px;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond {
    display: flex;
    width: 100%;
    align-items: center;
    justify-content: space-between;
    padding: 8px 10px;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .coinnameheading {
    font-family: "Poppins";
    font-style: normal;
    margin-left: 10px;
    font-weight: 500;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    opacity: 0.6;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub {
    display: flex;
    align-items: center;
    padding: 0px 10px;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub .bitcoinheading {
    margin-left: 10px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    margin-top: 5px;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst {
    display: flex;
    width: 100%;
    background: #272727;
    border-radius: 14px;
    align-items: center;
    justify-content: space-between;
    padding: 8px 10px;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .coinnameheading {
    font-family: "Poppins";
    font-style: normal;
    margin-left: 10px;
    font-weight: 500;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    opacity: 0.6;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub {
    display: flex;
    margin-left: 10px;
    align-items: center;
    width: 100%;
  }

  .assetsmainsection .tabscontainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub .bitcoinheading {
    margin-left: 10px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    margin-top: 5px;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }
}
@media screen and (max-width: 500px) {
  .topdiv {
    padding-left: 10px;
  }

  .topdiv .headmain .videolesson {
    font-size: 26px;
  }

  .topdiv .headmain .parahead {
    margin-top: -18px;
  }

  .firstcontainer {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    margin-left: 0 !important;
  }

  .firstcontainer .mainContainer {
    margin-top: 0px;
    width: 100%;
  }

  .firstcontainer .mainContainer .tabscontainer {
    margin-right: 0px;
    margin-left: 0px;
  }

  .firstcontainer .mainContainer .tabscontainer .tabsmaincontainer {
    display: flex;
    align-items: center;
    justify-content: space-around;
    padding: 20px 0px 0px 0px;
    padding-bottom: 16px;
  }

  .firstcontainer .mainContainer .tabscontainer .tabsmaincontainer .navitemclass {
    text-decoration: none;
    list-style-type: none;
    list-style: none;
    width: auto;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 27px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .tabscontentcontainer {
    display: flex;
    align-items: center;
    flex-direction: column;
    padding: 20px 7px;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysectionsecond {
    border-radius: 14px;
    background: #272727;
    margin-top: 10px;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond {
    display: flex;
    width: 100%;
    align-items: center;
    justify-content: space-between;
    padding: 8px 10px;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .coinnameheading {
    font-family: "Poppins";
    font-style: normal;
    margin-left: 10px;
    font-weight: 500;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    opacity: 0.6;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub {
    display: flex;
    align-items: center;
    padding: 0px 10px;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysectionsecond .buysubsectionsecond .buysectioncontentsub .bitcoinheading {
    margin-left: 10px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    margin-top: 5px;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysubsectionfirst {
    display: flex;
    width: 400px !important;
    background: #272727;
    border-radius: 14px;
    align-items: center;
    justify-content: space-between;
    padding: 8px 10px;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysubsectionfirst .coinnameheading {
    font-family: "Poppins";
    font-style: normal;
    margin-left: 10px;
    font-weight: 500;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    opacity: 0.6;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub {
    display: flex;
    margin-left: 10px;
    align-items: center;
    width: 100%;
  }

  .firstcontainer .mainContainer .tabscontentcontainer .buysubsectionfirst .buysectioncontentsub .bitcoinheading {
    margin-left: 10px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    margin-top: 5px;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .secondmaincontainer {
    padding: 40px;
    border-radius: 30px;
    width: 100%;
    position: relative;
    background: #0e0e0e;
  }

  .firstcontainer .mainContainer .secondmaincontainer .containerimage1 {
    position: absolute;
    left: 40%;
    top: 0;
  }

  .firstcontainer .mainContainer .secondmaincontainer .containerimage2 {
    position: absolute;
    right: 0;
    bottom: 0;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer {
    width: 100%;
    display: flex;
    justify-content: space-between;
    align-items: flex-end;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer {
    display: flex;
    margin-top: 10px;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .thirdsubsubcontainer {
    background: #323232;
    border-radius: 14px;
    padding: 14px 10px 0px 10px;
    display: flex;
    align-items: center;
    flex-direction: column;
  }

  .firstcontainer .mainContainer .secondmaincontainer .thirdcontainer .thirdsubcontainer .transactions {
    margin-left: 14px;
  }

  .firstcontainer .mainContainer .secondmaincontainer .paratext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .secondmaincontainer .paratexttwo {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    margin-bottom: 5px;
    font-size: 12px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.55;
  }

  .firstcontainer .mainContainer .secondmaincontainer .lastactivityclass {
    display: flex;
    width: 100%;
    flex-wrap: wrap;
    margin-left: 20px;
    font-size: 10px;
  }

  .firstcontainer .mainContainer .secondmaincontainer .headertext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 16px;
    line-height: 36px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .secondmaincontainer .parayellowtext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 40px;
    line-height: 75px;
    color: #ffbb54;
  }

  .firstcontainer .mainContainer .assetsmainsection {
    display: flex;
    flex-direction: column;
    padding: 0px 20px;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer {
    margin-top: 30px;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 16px;
    line-height: 24px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer {
    display: flex;
    padding: 10px 30px 10px 30px;
    justify-content: space-evenly;
    background: #0e0e0e;
    border-radius: 18px;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer {
    display: flex;
    margin-left: 20px;
    flex-direction: column;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .canvasgraphcontainer {
    width: 100%;
    margin-left: 30px;
    margin-right: 30px;
  }

  .canvasgraphcontainer .canvasgraph {
    height: 100px !important;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .bitcoinheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 24px;
    line-height: 36px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .BTCheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.8;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .sellheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #14bd6c;
    margin-left: 10px;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .assetsubfirstcontainer .firstnumberheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 20px;
    line-height: 30px;
    color: #ffffff;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer {
    align-items: center;
    display: flex;
    flex-direction: column;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .seconddateheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 12px;
    line-height: 18px;
    text-align: right;
    color: #ffffff;
    opacity: 0.6;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .coinbaseheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 10px;
    line-height: 15px;
    color: #ffffff;
    opacity: 0.4;
  }

  .firstcontainer .mainContainer .assetsmainsection .assetmaincontainer .assetsfirstcontainer .thirdassetcontainer .lastdateheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 18px;
    line-height: 27px;
    color: #14bd6c;
  }

  .firstcontainer .twocontainer {
    background: #0e0e0e;
    border-radius: 18px;
    width: 100%;
    height: 100%;
    margin-top: 30px;
    margin-left: 0px;
  }

  .firstcontainer .twocontainer .twosubcontainer {
    display: flex;
    justify-content: space-between;
    padding: 20px 20px;
  }

  .firstcontainer .twocontainer .twosubcontainer .paratexttwo {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
    opacity: 0.55;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer {
    width: 90px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownmaincontainer .dropdownbutton {
    background: #0e0e0e;
    border-radius: 18px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer {
    width: 20%;
    position: relative;
    left: -200px;
    background: #161616;
    border-radius: 12px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer {
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    border-bottom: 1px solid black;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer {
    display: flex;
    flex-direction: column;
    margin-top: 10px;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .btcheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }

  .firstcontainer .twocontainer .twosubcontainer .dropdownshowcontainer .dropdownsecondcontainer .dropdownthirdcontainer .numberheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 12px;
    line-height: 16px;
    /* identical to box height, or 133% */
    display: flex;
    align-items: center;
    color: #aeb6ce;
  }

  .firstcontainer .twosubcontainervalue {
    margin-left: 20px;
    display: flex;
    align-items: center;
  }

  .firstcontainer .twosubcontainervalue .greenrating {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 10px;
    line-height: 15px;
    margin-left: 20px;
    margin-top: 10px;
    color: #3ed10a;
  }

  .firstcontainer .twosubcontainervalue .headertext {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 20px;
    line-height: 30px;
    color: #ffffff;
  }
}
/*# sourceMappingURL=style.css.map */
/*# sourceMappingURL=style.scss.map */

/*# sourceMappingURL=style.cs.map */