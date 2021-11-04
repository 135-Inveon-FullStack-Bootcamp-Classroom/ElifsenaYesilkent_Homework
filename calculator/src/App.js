import './App.css';
import AppContainer from './Components/AppContainer';
import Keys from './Components/Keys';
import Screen from './Components/Screen';
import TopHeader from './Components/TopHeader';

function App() {
  return (
   <AppContainer>
     <TopHeader/>
     <Screen/>
     <Keys/>
    </AppContainer>
  );
}

export default App;
