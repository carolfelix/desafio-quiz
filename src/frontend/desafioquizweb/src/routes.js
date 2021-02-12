import React from 'react';
import { Switch, Route, BrowserRouter } from 'react-router-dom';

import Quiz from './pages/Quiz';

const Routes = () => (
    <BrowserRouter>
        <Switch>
            <Route exact path="/" component={Quiz} />
        </Switch>
    </BrowserRouter>
)  

export default Routes;