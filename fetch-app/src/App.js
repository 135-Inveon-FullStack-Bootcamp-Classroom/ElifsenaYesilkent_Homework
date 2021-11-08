import logo from './logo.svg';
import './App.css';
import {useState,useEffect} from "react"; 

function App() {

  const [error, setError] = useState(null);
  const [isLoaded, setIsLoaded] = useState(false);
  const [items, setItems] = useState([]);
  const [data,setData]=useState();
  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/albums/1/photos")
      .then(res => res.json())
      .then(
        (result) => {
          setIsLoaded(true);
          setItems(result);
        },
        // Note: it's important to handle errors here
        // instead of a catch() block so that we don't swallow
        // exceptions from actual bugs in components.
        (error) => {
          setIsLoaded(true);
          setError(error);
        }
      )
  }, [])
  return (
    <div className="App" >
      <div style={{fontSize:"20px" , display:"flex" , flexDirection: "row", justifyContent: "center"}}>
        <h1>  COLOR</h1>
      </div>
      <br/>
       <ul style={{listStyleType:"none",  display:"flex", flexDirection:"row",flexWrap:"wrap",justifyContent:"space-around"}}>
        {items.map(item => (
          <div style={{padding:"10px"}}>
            <li style={{paddingTop:"15px", border: "3px solid black", height:"190px", width:"200px"}} key={item.id}>
              <img src={item.url} style={{width:"100px", height:"100px"}}></img>
              <br/>
              <b>{item.title}</b>
            </li>
          </div>
        ))}
      </ul>
    </div>
  );
}

export default App;
