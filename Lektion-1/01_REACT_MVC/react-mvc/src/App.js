import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import ProductRoutes from './Controllers/ProductController';
import UserRoutes from './Controllers/UserRoutes';

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <UserRoutes />
          <ProductRoutes />
        </Routes>
      </BrowserRouter>
    </>
  );
}

// MV*

export default App;
