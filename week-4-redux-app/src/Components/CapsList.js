import { useEffect, useState } from "react";
import Layout from "./Layout";
import MemeCard from "./MemeCard";

// setMemes(result.data.memes))

const CapsList=()=>{
    const [memes,setMemes]=useState();

    useEffect(()=>{
        fetch("https://api.imgflip.com/get_memes")
        .then((response)=> response.json())
        .then((result)=>setMemes(result.data.memes));

    },[]);
   if (!memes) return <p>loading...</p>
    return (
        <Layout>
          {memes.map(meme=>(
              <MemeCard img={meme.url} title={meme.name}/>
          ))}
            
            
        </Layout>
    );
};

export default CapsList;