import React from 'react';
import { Route } from 'react-router-dom';
import Main from './Main';
import LoginScreen from './LoginScreen';
import Creation from './CreateAcc';
import Profile from './Profile';
import Registrated from './Registrated';
import { BrowserRouter, Switch } from 'react-router-dom/cjs/react-router-dom.min';


const AppNavigation = () => {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/" exact component={Main}  >
          <Main/>
        </Route>

        <Route path="/Registrated" component={Registrated} >
          <Registrated/>
        </Route>
        <Route path="/LoginScreen" component={LoginScreen} >
          <LoginScreen/>
        </Route>
        <Route path="/CreateAcc" component={Creation} >
          <Creation/>
        </Route>
        <Route path="/Profile" component={Profile} >
          <Profile/>
        </Route>
      </Switch>
    </BrowserRouter>
  );
};

export default AppNavigation;
