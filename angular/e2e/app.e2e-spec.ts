import { projetTemplatePage } from './app.po';

describe('projet App', function() {
  let page: projetTemplatePage;

  beforeEach(() => {
    page = new projetTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
