import Header from "../Header";


const Layout=({children})=>{
    return(
        <div className="App">
            <Header/>
            <div>{children}</div>
        </div>
    );
};

export default Layout;